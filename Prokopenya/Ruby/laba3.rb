require 'matrix'

n = 5

arr = []

(0...n).each do |i|
	arr[i] = Array.new(n.to_i){rand(10)}
end

0.upto(arr.size - 1) { |i| p arr[i] }

print "Матрица скалярная? - "
puts Matrix.scalar(arr.size, arr[0][0]) == Matrix[*arr]
