# %% [markdown]
# # Jupyter Notebook 사용법 학습
# 
# ## Markdown, Python Shell 추가
# - 현재 셀 앞에 셀 추가 : a
# - 현재 셀 뒤에 셀 추가 : b
# - 마크다운으로 셀 변경 : esc > M
# - 파이썬으로 셀 변경 : esc > Y 
# 
# ## Python 실행
# - 셀 실행 : Ctrl + Enter
# - 셀 실행 후 새 셀 생성 : Alt + Enter
# - 셀 실행 후 새 셀 생성 (아래 이미 있으면 안 만듦) : Shift + Enter
# - 주석 처리 : Ctrl + / 혹은 Ctrl + K, C

# %%
# 최초 작성된 Python Shell

# %%
print('Hello Jupyter')

# %% [markdown]
# # Debugging
# 
# - 실행 및 디버그 : Ctrl + Shift + Alt + Enter
#     - F10, F11 로 진행 가능
# - 만약 안 될 경우 : 설정 > Jupyter Debug 설정 조작

# %%
arr = [1, '2', True, 'Hello', 3.1415926585]

for i in arr:
    print(i)

# %%
def plus(x, y):
    return x + y

print(plus(10, 4))

# %%
def div(x, y):
    return x / y

print(div(10, 0))

# %%



