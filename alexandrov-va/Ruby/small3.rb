require 'matrix'

arr = [[4, 0, 0, 0], [0, 4, 0, 0], [0, 0, 4, 0], [0, 0, 0, 4]]

print "Матрица скалярная? - "
puts Matrix.scalar(arr.size, arr[0][0]) == Matrix[*arr]
