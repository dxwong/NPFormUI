#!/bin/bash

echo "🚀 开始强制推送到公共仓库..."
echo "时间戳: $(date)"

# 检查 .gitignore 是否存在
if [ ! -f ".gitignore" ]; then
    echo "❌ 错误: 未找到 .gitignore 文件"
    read -p "按回车键退出..."
    exit 1
fi

# 确保脚本自身不在暂存区
if git status --short | grep -q "push.sh"; then
    echo "⏹️  从暂存区移除 push.sh..."
    git reset push.sh
fi

# 使用 git add . (会自动遵循 .gitignore)
git add .
echo "文件已添加（遵循 .gitignore 规则）"

# 显示将要提交的文件
echo "📁 将要提交的文件："
git status --short

# 双重检查：确保 push.sh 没有被意外添加
if git diff --cached --name-only | grep -q "push.sh"; then
    echo "⚠️  检测到 push.sh 在暂存区，正在移除..."
    git reset push.sh
    echo " 已移除 push.sh"
fi

# 提交
commit_msg="r$(date +%m%d%H%M)"
git commit -m "$commit_msg" --allow-empty
echo "已提交: $commit_msg"

# 强制推送到公共仓库
echo "🌐 正在推送到公共仓库..."
git push https://github.com/dxwong/NPFormUI.git main --force || {
    echo "❌ 网络异常！推送失败，请检查网络连接后重试"
    read -p "按回车键退出..."
    exit 1
}

echo "🎉 强制推送完成！"
echo "📅 推送时间: $(date)"
read -p "按回车键退出..."