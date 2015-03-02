
puts "Введите n:"
n = gets.chomp
puts "Введите m:"
m = gets.chomp
matrix = []
for i in 0...n.to_i do
  matrix << []
  for j in 0...m.to_i do
    matrix[i] << rand(100)-100
  end
  puts matrix[i].to_s
  puts ""
end
maxOfStr = 0
minmax = 1000000
for i in 0...n.to_i do
  for j in 0...m.to_i do
    if (matrix[i][j] > matrix[i][maxOfStr])
      maxOfStr = j
    end
  end
  if (matrix[i][maxOfStr] < minmax)
    minmax = matrix[i][maxOfStr]
  end
end
puts "Минимакс = "+minmax.to_s