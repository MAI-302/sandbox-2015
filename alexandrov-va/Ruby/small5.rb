require 'matrix'

n = 4

arr = []

(0...n).each do |i|
	arr[i] = Array.new(n){ rand(100) - 50}
	print arr[i]
	puts ""
end

print "Определитель матрицы: "
puts Matrix[*arr].det
