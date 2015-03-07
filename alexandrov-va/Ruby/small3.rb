require 'matrix'

arr = [[4, 0, 0, 0], [0, 4, 0, 0], [0, 0, 4, 0], [0, 0, 0, 4]]

0.upto(arr.size - 1) { |i| p arr[i] }

print "Матрица скалярная? - "
puts Matrix.scalar(arr.size, arr[0][0]) == Matrix[*arr]
