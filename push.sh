#!/bin/bash
set -e

echo "🚀 开始强制推送到公共仓库..."
echo "时间戳: $(date)"

# 检查 .gitignore 是否存在
if [ ! -f ".gitignore" ]; then
    echo "❌ 错误: 未找到 .gitignore 文件"
    exit 1
fi

# 如果 push.sh 之前已被提交，从 Git 中删除它（但保留本地文件）
if git ls-files | grep -q "push.sh"; then
    echo "🗑️  从 Git 记录中移除 push.sh..."
    git rm --cached push.sh
fi

echo "📋 使用 .gitignore 规则排除文件..."
git add .

# 额外确保 push.sh 不在暂存区
if [ -f "push.sh" ]; then
    git reset push.sh
    echo "✅ 已额外排除 push.sh 文件"
fi

echo "✅ 文件已添加（遵循 .gitignore 规则 + 排除 push.sh）"

# 显示将要提交的文件
echo "📁 将要提交的文件："
git status --short

# 提交
commit_msg="r$(date +%m%d%H%M)"
git commit -m "$commit_msg" --allow-empty
echo "✅ 已提交: $commit_msg"

# 强制推送到公共仓库
echo "正在推送到公共仓库..."
git push https://github.com/dxwong/NPFormUI.git main --force

echo "🎉 强制推送完成！"
echo "推送时间: $(date)"
read -p "按回车键退出..."