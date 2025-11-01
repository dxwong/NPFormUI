#!/bin/bash
set -e  # 遇到错误立即退出

echo "🚀 开始强制推送流程..."
echo "时间戳: $(date)"

# 添加所有更改
git add -A
echo "✅ 文件已添加"

# 提交（允许空提交）
commit_msg="r$(date +%m%d%H%M)"
git commit -m "$commit_msg" --allow-empty
echo "✅ 已提交: $commit_msg"

# 强制推送
echo "正在推送到远程仓库..."
git push https://github.com/dxwong/NPFormUI.git main --force

echo "🎉 强制推送完成！"
echo "推送时间: $(date)"
read -p "按回车键退出..."