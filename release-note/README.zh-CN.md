## Release  Notes

<div align="center">
<p><a href="https://www.nuget.org/packages/MiniWord"><img src="https://img.shields.io/nuget/v/MiniWord.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniWord"><img src="https://img.shields.io/nuget/dt/MiniWord.svg" alt=""></a>  
<a href="https://github.com/mini-software/MiniWord" rel="nofollow"><img src="https://img.shields.io/github/stars/mini-software/MiniWord?logo=github" alt="GitHub stars"></a> 
<a href="https://www.nuget.org/packages/MiniWord"><img src="https://img.shields.io/badge/.NET-%3E%3D%204.5-red.svg" alt="version"></a>
</p>
</div>


---

<div align="center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a></strong></p>
</div>

---

<div align="center">
 Your <a href="https://github.com/mini-software/MiniWord">Star</a> and <a href="https://miniexcel.github.io">Donate</a> can make MiniWord better 
</div>

---

### 0.6.1
- [Bug] 修正系统不支持 `IEnumerable<MiniWordHyperLink>` (#39 via @isdaniel)

### 0.6.0
- [New] 支持 hyperLink  (#33 via @isdaniel)
- [New] 支持 custom font color and highlight color (#35 via impPDX)
- [New] 支持 2 level object parameter (#32 via @ping9719 , @shps951023)
- [Bug] 修正 Multiple tags format error (#37 via @shps951023)

### 0.5.0

- [New] 支持 object & dynamic parameter (#19 via @isdaniel )

### 0.4.0
- [New] 支持HeaderParts, FooterParts template
- [Bug] 修正multiple table generate problem #18

### 0.3.0
- [New] 支持 table 标签  #13
- [New] datetime format -> yyyy-MM-dd HH:mm:ss
- [Bug] fixed spliting template string like `<w:t>{</w:t><w:t>{<w:/t><w:t>Tag</w:t><w:t>}</w:t><w:t>}<w:/t>` problem #17

### 0.2.1

- [Bug] fixed mutiple tag System.InvalidOperationException: 'The parent of this element is null.' #13

### 0.2.0

- [Feature] 支持 array list string 生成多行 #11
- [Feature] 支持图片 #10 #3
- [Feature] 图片支持自定义 width 和 height #8
- [Feature] 支持多 breakline
- [Optimize] 删除 xmlns declaration #7

### 0.1.1
- [Bug] 修正 Fuzzy Regex replace similar key


### 0.1.0
- 基本 template 导出

### 0.0.0
- Init