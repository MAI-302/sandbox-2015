arr = [[6, 3, -4], [7, 3, 1], [-2, 0, 3]]

print "Исходный массив: "
print arr
puts ""

print "Минимальный из максимальных элементов строк: "
puts arr.map{ |a| a.max }.min
