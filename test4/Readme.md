# 实验四 
## Word考试自动批改程序

## 实验目的和要求：
- 本实验在上一个实验（实验3）的基础上进行。要求对每个考生的答卷（docx文档）进行自动阅卷并评分，最后把评分写入一个二进制文件中。
- 样例文件在老师的test4目录中。本实验的输入是：原题.docx，标准答案.docx，以及考生答案目录(students_answer)，在考生答案目录中存放的是考生的作答文件，每个考生文件的命名方式是考号_姓名.docx。程序必需能够自动对考生答案目录中的每个文件进行评分。
- 本实验的输出是一个二进制成绩结果文件。比如result.dat，这个文件的中存放了每个考生的个人信息和成绩。本实验必须能够写result.dat文件，并且把文件内容再正确的读出来。
 
## 知识点：
- LCS
- 泛型
- 运算符重载
- 二维数组
- 递归调用
- 使用VS2017中的NuGet安装项目的外部引用。
- 熟悉Word文件的XML格式。
- 熟悉XML格式及OpenXmlElement处理，熟悉XML中对象的遍历。
- 文件读写
- 目录遍历

## NuGet安装项目的外部引用
点击项目右键》联网查询》搜索openXml 找到对应安装包，点击安装

## OpenXmlElement 类
表示一个基类派生自的 Office Open XML 文档中的所有元素。Elements<T>()枚举仅将具有指定的类型的当前元素的子级

## 实验理解
- 本次作业用到了前三次的作业及上课新教内容：
   - LCS 最长公共子序列，目的是为了找出考生与标准答案的相同与不相同。
   - openxml解析word文档，进行答案对比。
   - 运用LCS找出考生答案和标准答案的不同信息（即替换部分），运用openxml来读取word文档里面的每一个对象文字。计算字符串中子串出现次数则为替换出现的次数。输出考生作答的结果。
   - 运用Windows窗口设计。
   - 运用文件读写，将评分结果放入result.dat文件，这个文件存放考生的个人信息和成绩，并把成绩的结果保存为二进制文件防止篡改成绩。
   


## 操作过程：
- 先创建一个新项目，为Windows窗体应用程序，在工具箱中把splitContainer拖动进主体中，然后在属性栏中找到Orientation 将值设置为Horizontal，使得上下排布，接着拖动按钮（buttonl），文本框（textbox），linklabel、label等。在下部分：点击DataGridview --属性--Dock填充。右键添加列
- 通过双击对应的部件可以进入编辑代码页面，也可单机设置事件等。
- 设置链接标签进行路径的选择，且在Settings.settings中设置默认路径盘，然后将路径显示在文本框中。
- 利用前面已经写好的LCS对比等前工作，创建类。GradeFile将成绩写入result.dat。
- 在Form中，得到需要的路径，将数据各部分分开读取并储存，最后显示到Form中。





## 运行结果
![ImageText](http://m.qpic.cn/psb?/V10uZ7S132PBtH/V0ffE9i*7NtEw8KSBrZqxxgGRTseT*tyiJ4rbUfa6DQ!/b/dDIBAAAAAAAA&bo=JAPmASQD5gEDGTw!&rf=viewer_4 )

