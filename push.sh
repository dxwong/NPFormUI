#!/bin/bash

echo "🚀 开始强制推送到公共仓库..."
echo "时间戳: $(date)"

# 使用 git add . 添加所有文件
git add .

# 关键步骤：从本次提交中移除 push.sh（即使它已被跟踪）
echo "🗑️  从本次提交中移除 push.sh..."
git reset push.sh

echo "✅ 文件已添加（已排除 push.sh）"

# 显示将要提交的文件
echo "📁 将要提交的文件："
git status --short

# 确认 push.sh 已被排除
if git diff --cached --name-only | grep -q "push.sh"; then
    echo "❌ 错误: push.sh 仍然在提交中，强制移除..."
    git reset push.sh
fi

# 提交
commit_msg="r$(date +%m%d%H%M)"
git commit -m "$commit_msg" --allow-empty
echo "✅ 已提交: $commit_msg"

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