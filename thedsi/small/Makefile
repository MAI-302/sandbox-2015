CSC = csc /nologo
RM = del /f /q

EXES = \
    small1.exe \
    small2.exe \
    small3.exe \
    small4.exe \
    small5.exe \
    small6.exe \
    small7.exe
    
all: $(EXES) small_tasks.exe

clean:
    $(RM) $(EXES) small_tasks.exe 2>NUL

$(EXES): $(@:.exe=.cs)
    $(CSC) /out:$@ $?

small_tasks.exe: small_tasks.cs $(EXES:.exe=.cs)
    $(CSC) /out:$@ /main:small_tasks $**

run: small_tasks.exe
    small_tasks.exe