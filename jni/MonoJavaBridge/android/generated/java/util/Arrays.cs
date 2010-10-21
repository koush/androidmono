namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Arrays : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Arrays()
		{
			InitJNI();
		}
		protected Arrays(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25652;
		public static bool equals(java.lang.Object[] arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25653;
		public static bool equals(float[] arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25654;
		public static bool equals(double[] arg0, double[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25655;
		public static bool equals(bool[] arg0, bool[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25656;
		public static bool equals(byte[] arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25657;
		public static bool equals(char[] arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25658;
		public static bool equals(short[] arg0, short[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25659;
		public static bool equals(int[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25660;
		public static bool equals(long[] arg0, long[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString25661;
		public static global::java.lang.String toString(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25662;
		public static global::java.lang.String toString(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25663;
		public static global::java.lang.String toString(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25664;
		public static global::java.lang.String toString(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25665;
		public static global::java.lang.String toString(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25666;
		public static global::java.lang.String toString(bool[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25667;
		public static global::java.lang.String toString(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25668;
		public static global::java.lang.String toString(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25669;
		public static global::java.lang.String toString(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25670;
		public static int hashCode(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25671;
		public static int hashCode(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25672;
		public static int hashCode(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25673;
		public static int hashCode(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25674;
		public static int hashCode(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25675;
		public static int hashCode(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25676;
		public static int hashCode(bool[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25677;
		public static int hashCode(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25678;
		public static int hashCode(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25679;
		public static int[] copyOf(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25680;
		public static global::java.lang.Object[] copyOf(java.lang.Object[] arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25681;
		public static float[] copyOf(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25682;
		public static double[] copyOf(double[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25683;
		public static bool[] copyOf(bool[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25684;
		public static char[] copyOf(char[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25685;
		public static long[] copyOf(long[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25686;
		public static global::java.lang.Object[] copyOf(java.lang.Object[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25687;
		public static byte[] copyOf(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25688;
		public static short[] copyOf(short[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25689;
		public static char[] copyOfRange(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25690;
		public static bool[] copyOfRange(bool[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25691;
		public static double[] copyOfRange(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25692;
		public static float[] copyOfRange(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25693;
		public static long[] copyOfRange(long[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25694;
		public static int[] copyOfRange(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25695;
		public static short[] copyOfRange(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25696;
		public static byte[] copyOfRange(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25697;
		public static global::java.lang.Object[] copyOfRange(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Class arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25698;
		public static global::java.lang.Object[] copyOfRange(java.lang.Object[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _fill25699;
		public static void fill(double[] arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25700;
		public static void fill(float[] arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25701;
		public static void fill(float[] arg0, int arg1, int arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25702;
		public static void fill(bool[] arg0, int arg1, int arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25703;
		public static void fill(byte[] arg0, int arg1, int arg2, byte arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25704;
		public static void fill(byte[] arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25705;
		public static void fill(char[] arg0, int arg1, int arg2, char arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25706;
		public static void fill(short[] arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25707;
		public static void fill(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25708;
		public static void fill(java.lang.Object[] arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25709;
		public static void fill(char[] arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25710;
		public static void fill(short[] arg0, int arg1, int arg2, short arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25711;
		public static void fill(long[] arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25712;
		public static void fill(long[] arg0, int arg1, int arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25713;
		public static void fill(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25714;
		public static void fill(int[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25715;
		public static void fill(bool[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25716;
		public static void fill(double[] arg0, int arg1, int arg2, double arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _sort25717;
		public static void sort(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25718;
		public static void sort(java.lang.Object[] arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sort25719;
		public static void sort(java.lang.Object[] arg0, int arg1, int arg2, java.util.Comparator arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _sort25720;
		public static void sort(long[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25721;
		public static void sort(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25722;
		public static void sort(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25723;
		public static void sort(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25724;
		public static void sort(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25725;
		public static void sort(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25726;
		public static void sort(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25727;
		public static void sort(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25728;
		public static void sort(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25729;
		public static void sort(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25730;
		public static void sort(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25731;
		public static void sort(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25732;
		public static void sort(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25733;
		public static void sort(java.lang.Object[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25734;
		public static void sort(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25735;
		public static int binarySearch(char[] arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25736;
		public static int binarySearch(java.lang.Object[] arg0, java.lang.Object arg1, java.util.Comparator arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25737;
		public static int binarySearch(short[] arg0, int arg1, int arg2, short arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25738;
		public static int binarySearch(short[] arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25739;
		public static int binarySearch(float[] arg0, int arg1, int arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25740;
		public static int binarySearch(int[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25741;
		public static int binarySearch(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25742;
		public static int binarySearch(float[] arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25743;
		public static int binarySearch(long[] arg0, int arg1, int arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25744;
		public static int binarySearch(double[] arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25745;
		public static int binarySearch(long[] arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25746;
		public static int binarySearch(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3, java.util.Comparator arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25747;
		public static int binarySearch(double[] arg0, int arg1, int arg2, double arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25748;
		public static int binarySearch(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25749;
		public static int binarySearch(byte[] arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25750;
		public static int binarySearch(byte[] arg0, int arg1, int arg2, byte arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25751;
		public static int binarySearch(java.lang.Object[] arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25752;
		public static int binarySearch(char[] arg0, int arg1, int arg2, char arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _asList25753;
		public static global::java.util.List asList(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._asList25753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _deepHashCode25754;
		public static int deepHashCode(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._deepHashCode25754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deepEquals25755;
		public static bool deepEquals(java.lang.Object[] arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._deepEquals25755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deepToString25756;
		public static global::java.lang.String deepToString(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._deepToString25756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Arrays.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Arrays"));
			global::java.util.Arrays._equals25652 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			global::java.util.Arrays._equals25653 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([F[F)Z");
			global::java.util.Arrays._equals25654 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([D[D)Z");
			global::java.util.Arrays._equals25655 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([Z[Z)Z");
			global::java.util.Arrays._equals25656 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([B[B)Z");
			global::java.util.Arrays._equals25657 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([C[C)Z");
			global::java.util.Arrays._equals25658 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([S[S)Z");
			global::java.util.Arrays._equals25659 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([I[I)Z");
			global::java.util.Arrays._equals25660 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([J[J)Z");
			global::java.util.Arrays._toString25661 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([Ljava/lang/Object;)Ljava/lang/String;");
			global::java.util.Arrays._toString25662 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([I)Ljava/lang/String;");
			global::java.util.Arrays._toString25663 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([S)Ljava/lang/String;");
			global::java.util.Arrays._toString25664 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([C)Ljava/lang/String;");
			global::java.util.Arrays._toString25665 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([B)Ljava/lang/String;");
			global::java.util.Arrays._toString25666 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([Z)Ljava/lang/String;");
			global::java.util.Arrays._toString25667 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([F)Ljava/lang/String;");
			global::java.util.Arrays._toString25668 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([D)Ljava/lang/String;");
			global::java.util.Arrays._toString25669 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([J)Ljava/lang/String;");
			global::java.util.Arrays._hashCode25670 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([F)I");
			global::java.util.Arrays._hashCode25671 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([J)I");
			global::java.util.Arrays._hashCode25672 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([I)I");
			global::java.util.Arrays._hashCode25673 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([S)I");
			global::java.util.Arrays._hashCode25674 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([C)I");
			global::java.util.Arrays._hashCode25675 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([B)I");
			global::java.util.Arrays._hashCode25676 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([Z)I");
			global::java.util.Arrays._hashCode25677 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([Ljava/lang/Object;)I");
			global::java.util.Arrays._hashCode25678 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([D)I");
			global::java.util.Arrays._copyOf25679 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([II)[I");
			global::java.util.Arrays._copyOf25680 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([Ljava/lang/Object;ILjava/lang/Class;)[Ljava/lang/Object;");
			global::java.util.Arrays._copyOf25681 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([FI)[F");
			global::java.util.Arrays._copyOf25682 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([DI)[D");
			global::java.util.Arrays._copyOf25683 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([ZI)[Z");
			global::java.util.Arrays._copyOf25684 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([CI)[C");
			global::java.util.Arrays._copyOf25685 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([JI)[J");
			global::java.util.Arrays._copyOf25686 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([Ljava/lang/Object;I)[Ljava/lang/Object;");
			global::java.util.Arrays._copyOf25687 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([BI)[B");
			global::java.util.Arrays._copyOf25688 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([SI)[S");
			global::java.util.Arrays._copyOfRange25689 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([CII)[C");
			global::java.util.Arrays._copyOfRange25690 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([ZII)[Z");
			global::java.util.Arrays._copyOfRange25691 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([DII)[D");
			global::java.util.Arrays._copyOfRange25692 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([FII)[F");
			global::java.util.Arrays._copyOfRange25693 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([JII)[J");
			global::java.util.Arrays._copyOfRange25694 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([III)[I");
			global::java.util.Arrays._copyOfRange25695 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([SII)[S");
			global::java.util.Arrays._copyOfRange25696 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([BII)[B");
			global::java.util.Arrays._copyOfRange25697 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([Ljava/lang/Object;IILjava/lang/Class;)[Ljava/lang/Object;");
			global::java.util.Arrays._copyOfRange25698 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([Ljava/lang/Object;II)[Ljava/lang/Object;");
			global::java.util.Arrays._fill25699 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([DD)V");
			global::java.util.Arrays._fill25700 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([FF)V");
			global::java.util.Arrays._fill25701 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([FIIF)V");
			global::java.util.Arrays._fill25702 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([ZIIZ)V");
			global::java.util.Arrays._fill25703 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([BIIB)V");
			global::java.util.Arrays._fill25704 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([BB)V");
			global::java.util.Arrays._fill25705 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([CIIC)V");
			global::java.util.Arrays._fill25706 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([SS)V");
			global::java.util.Arrays._fill25707 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([Ljava/lang/Object;IILjava/lang/Object;)V");
			global::java.util.Arrays._fill25708 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.util.Arrays._fill25709 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([CC)V");
			global::java.util.Arrays._fill25710 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([SIIS)V");
			global::java.util.Arrays._fill25711 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([JJ)V");
			global::java.util.Arrays._fill25712 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([JIIJ)V");
			global::java.util.Arrays._fill25713 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([II)V");
			global::java.util.Arrays._fill25714 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([IIII)V");
			global::java.util.Arrays._fill25715 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([ZZ)V");
			global::java.util.Arrays._fill25716 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([DIID)V");
			global::java.util.Arrays._sort25717 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([I)V");
			global::java.util.Arrays._sort25718 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;Ljava/util/Comparator;)V");
			global::java.util.Arrays._sort25719 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;IILjava/util/Comparator;)V");
			global::java.util.Arrays._sort25720 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([JII)V");
			global::java.util.Arrays._sort25721 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([J)V");
			global::java.util.Arrays._sort25722 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([FII)V");
			global::java.util.Arrays._sort25723 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([F)V");
			global::java.util.Arrays._sort25724 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([DII)V");
			global::java.util.Arrays._sort25725 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([D)V");
			global::java.util.Arrays._sort25726 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([BII)V");
			global::java.util.Arrays._sort25727 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([B)V");
			global::java.util.Arrays._sort25728 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([CII)V");
			global::java.util.Arrays._sort25729 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([S)V");
			global::java.util.Arrays._sort25730 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([SII)V");
			global::java.util.Arrays._sort25731 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([III)V");
			global::java.util.Arrays._sort25732 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;)V");
			global::java.util.Arrays._sort25733 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;II)V");
			global::java.util.Arrays._sort25734 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([C)V");
			global::java.util.Arrays._binarySearch25735 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([CC)I");
			global::java.util.Arrays._binarySearch25736 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I");
			global::java.util.Arrays._binarySearch25737 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([SIIS)I");
			global::java.util.Arrays._binarySearch25738 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([SS)I");
			global::java.util.Arrays._binarySearch25739 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([FIIF)I");
			global::java.util.Arrays._binarySearch25740 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([IIII)I");
			global::java.util.Arrays._binarySearch25741 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([II)I");
			global::java.util.Arrays._binarySearch25742 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([FF)I");
			global::java.util.Arrays._binarySearch25743 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([JIIJ)I");
			global::java.util.Arrays._binarySearch25744 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([DD)I");
			global::java.util.Arrays._binarySearch25745 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([JJ)I");
			global::java.util.Arrays._binarySearch25746 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I");
			global::java.util.Arrays._binarySearch25747 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([DIID)I");
			global::java.util.Arrays._binarySearch25748 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;)I");
			global::java.util.Arrays._binarySearch25749 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([BB)I");
			global::java.util.Arrays._binarySearch25750 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([BIIB)I");
			global::java.util.Arrays._binarySearch25751 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;)I");
			global::java.util.Arrays._binarySearch25752 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([CIIC)I");
			global::java.util.Arrays._asList25753 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "asList", "([Ljava/lang/Object;)Ljava/util/List;");
			global::java.util.Arrays._deepHashCode25754 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepHashCode", "([Ljava/lang/Object;)I");
			global::java.util.Arrays._deepEquals25755 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			global::java.util.Arrays._deepToString25756 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepToString", "([Ljava/lang/Object;)Ljava/lang/String;");
		}
	}
}
