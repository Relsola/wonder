## 安装 [powershell](https://learn.microsoft.com/zh-cn/powershell/scripting/install/installing-powershell-on-windows?view=powershell-7.3)

```bash
# 搜索最新版本的 PowerShell
winget search Microsoft.PowerShell

# 使用 id 安装指定版本
winget install --id Microsoft.Powershell.Preview --source winget
```

## 打开 powershell，安装 [oh My Posh](https://ohmyposh.dev/docs/installation/windows)

```bash
# 安装
winget install JanDeDobbeleer.OhMyPosh -s winget
```

## 修改 oh My Posh 的配置文件

配置文件地址 `C:\Users\<username>\Documents\PowerShell\Microsoft.PowerShell_profile.ps1`

```bash
# 打开配置文件
notepad $PROFILE

# 配置文件中添加配置并保存
oh-my-posh init pwsh | Invoke-Expression

# 重新载入配置文件
. $PROFILE
```

## 修改配置文件

安装字体 [https://www.nerdfonts.com/font-downloads](https://www.nerdfonts.com/font-downloads)
本地存放主题的目录： `C:\Users\<username>\AppData\Local\Programs\oh-my-posh\themes`
主题参考： [https://ohmyposh.dev/docs/themes](https://ohmyposh.dev/docs/themes)

```bash
# 我使用的是 M365Princess 主题
oh-my-posh init pwsh --config 'C:\Users\Reset\AppData\Local\Programs\oh-my-posh\themes\M365Princess.omp.json' | Invoke-Expression

# 设置 powershell 打开的路径
set-location C:\Users\Reset
```
