require 'matrix'
puts "Задайте размер матрицы n:"
n = gets.chomp.to_i
arr = []
(0...n).each do |i|
	arr[i] = []
	(0...n).each do |j|
		arr[i][j] = rand(100) - rand(100)
	end
	print arr[i]
	puts ""
end

print "Определитель матрицы  = "
print Matrix[*arr].det