require 'matrix'

n = 4

arr = []

(0...n).each do |i|
	arr[i] = []
	(0...n).each do |j|
		arr[i][j] = rand(100) - 50
	end
	print arr[i]
	puts ""
end

print "Определитель матрицы: "
puts Matrix[*arr].det
