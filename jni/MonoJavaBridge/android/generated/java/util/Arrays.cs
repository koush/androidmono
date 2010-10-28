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
		internal static global::MonoJavaBridge.MethodId _equals25771;
		public static bool equals(java.lang.Object[] arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25772;
		public static bool equals(float[] arg0, float[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25773;
		public static bool equals(double[] arg0, double[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25774;
		public static bool equals(bool[] arg0, bool[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25775;
		public static bool equals(byte[] arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25776;
		public static bool equals(char[] arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25777;
		public static bool equals(short[] arg0, short[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25778;
		public static bool equals(int[] arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals25779;
		public static bool equals(long[] arg0, long[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals25779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString25780;
		public static global::java.lang.String toString(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25781;
		public static global::java.lang.String toString(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25782;
		public static global::java.lang.String toString(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25783;
		public static global::java.lang.String toString(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25784;
		public static global::java.lang.String toString(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25785;
		public static global::java.lang.String toString(bool[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25786;
		public static global::java.lang.String toString(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25787;
		public static global::java.lang.String toString(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString25788;
		public static global::java.lang.String toString(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString25788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25789;
		public static int hashCode(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25790;
		public static int hashCode(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25791;
		public static int hashCode(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25792;
		public static int hashCode(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25793;
		public static int hashCode(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25794;
		public static int hashCode(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25795;
		public static int hashCode(bool[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25796;
		public static int hashCode(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25797;
		public static int hashCode(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode25797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25798;
		public static int[] copyOf(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25799;
		public static global::java.lang.Object[] copyOf(java.lang.Object[] arg0, int arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25800;
		public static float[] copyOf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25801;
		public static double[] copyOf(double[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25802;
		public static bool[] copyOf(bool[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25803;
		public static char[] copyOf(char[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25804;
		public static long[] copyOf(long[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25805;
		public static global::java.lang.Object[] copyOf(java.lang.Object[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25806;
		public static byte[] copyOf(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf25807;
		public static short[] copyOf(short[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf25807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25808;
		public static char[] copyOfRange(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25809;
		public static bool[] copyOfRange(bool[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25810;
		public static double[] copyOfRange(double[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25811;
		public static float[] copyOfRange(float[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25812;
		public static long[] copyOfRange(long[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25813;
		public static int[] copyOfRange(int[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25814;
		public static short[] copyOfRange(short[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25815;
		public static byte[] copyOfRange(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25816;
		public static global::java.lang.Object[] copyOfRange(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Class arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange25817;
		public static global::java.lang.Object[] copyOfRange(java.lang.Object[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange25817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _fill25818;
		public static void fill(double[] arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25819;
		public static void fill(float[] arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25820;
		public static void fill(float[] arg0, int arg1, int arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25821;
		public static void fill(bool[] arg0, int arg1, int arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25822;
		public static void fill(byte[] arg0, int arg1, int arg2, byte arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25823;
		public static void fill(byte[] arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25824;
		public static void fill(char[] arg0, int arg1, int arg2, char arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25825;
		public static void fill(short[] arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25826;
		public static void fill(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25827;
		public static void fill(java.lang.Object[] arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25828;
		public static void fill(char[] arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25829;
		public static void fill(short[] arg0, int arg1, int arg2, short arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25830;
		public static void fill(long[] arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25831;
		public static void fill(long[] arg0, int arg1, int arg2, long arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25832;
		public static void fill(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25833;
		public static void fill(int[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill25834;
		public static void fill(bool[] arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill25835;
		public static void fill(double[] arg0, int arg1, int arg2, double arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill25835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _sort25836;
		public static void sort(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25837;
		public static void sort(java.lang.Object[] arg0, java.util.Comparator arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sort25838;
		public static void sort(java.lang.Object[] arg0, int arg1, int arg2, java.util.Comparator arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _sort25839;
		public static void sort(long[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25840;
		public static void sort(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25841;
		public static void sort(float[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25842;
		public static void sort(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25843;
		public static void sort(double[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25844;
		public static void sort(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25845;
		public static void sort(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25846;
		public static void sort(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25847;
		public static void sort(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25848;
		public static void sort(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25849;
		public static void sort(short[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25850;
		public static void sort(int[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25851;
		public static void sort(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25852;
		public static void sort(java.lang.Object[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort25853;
		public static void sort(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort25853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25854;
		public static int binarySearch(char[] arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25855;
		public static int binarySearch(java.lang.Object[] arg0, java.lang.Object arg1, java.util.Comparator arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25856;
		public static int binarySearch(short[] arg0, int arg1, int arg2, short arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25857;
		public static int binarySearch(short[] arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25858;
		public static int binarySearch(float[] arg0, int arg1, int arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25859;
		public static int binarySearch(int[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25860;
		public static int binarySearch(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25861;
		public static int binarySearch(float[] arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25862;
		public static int binarySearch(long[] arg0, int arg1, int arg2, long arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25863;
		public static int binarySearch(double[] arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25864;
		public static int binarySearch(long[] arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25865;
		public static int binarySearch(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3, java.util.Comparator arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25866;
		public static int binarySearch(double[] arg0, int arg1, int arg2, double arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25867;
		public static int binarySearch(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25868;
		public static int binarySearch(byte[] arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25869;
		public static int binarySearch(byte[] arg0, int arg1, int arg2, byte arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25870;
		public static int binarySearch(java.lang.Object[] arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25871;
		public static int binarySearch(char[] arg0, int arg1, int arg2, char arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch25871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _asList25872;
		public static global::java.util.List asList(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._asList25872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _deepHashCode25873;
		public static int deepHashCode(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._deepHashCode25873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deepEquals25874;
		public static bool deepEquals(java.lang.Object[] arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._deepEquals25874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deepToString25875;
		public static global::java.lang.String deepToString(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._deepToString25875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Arrays.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Arrays"));
			global::java.util.Arrays._equals25771 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			global::java.util.Arrays._equals25772 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([F[F)Z");
			global::java.util.Arrays._equals25773 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([D[D)Z");
			global::java.util.Arrays._equals25774 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([Z[Z)Z");
			global::java.util.Arrays._equals25775 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([B[B)Z");
			global::java.util.Arrays._equals25776 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([C[C)Z");
			global::java.util.Arrays._equals25777 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([S[S)Z");
			global::java.util.Arrays._equals25778 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([I[I)Z");
			global::java.util.Arrays._equals25779 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([J[J)Z");
			global::java.util.Arrays._toString25780 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([Ljava/lang/Object;)Ljava/lang/String;");
			global::java.util.Arrays._toString25781 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([I)Ljava/lang/String;");
			global::java.util.Arrays._toString25782 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([S)Ljava/lang/String;");
			global::java.util.Arrays._toString25783 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([C)Ljava/lang/String;");
			global::java.util.Arrays._toString25784 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([B)Ljava/lang/String;");
			global::java.util.Arrays._toString25785 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([Z)Ljava/lang/String;");
			global::java.util.Arrays._toString25786 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([F)Ljava/lang/String;");
			global::java.util.Arrays._toString25787 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([D)Ljava/lang/String;");
			global::java.util.Arrays._toString25788 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([J)Ljava/lang/String;");
			global::java.util.Arrays._hashCode25789 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([F)I");
			global::java.util.Arrays._hashCode25790 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([J)I");
			global::java.util.Arrays._hashCode25791 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([I)I");
			global::java.util.Arrays._hashCode25792 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([S)I");
			global::java.util.Arrays._hashCode25793 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([C)I");
			global::java.util.Arrays._hashCode25794 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([B)I");
			global::java.util.Arrays._hashCode25795 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([Z)I");
			global::java.util.Arrays._hashCode25796 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([Ljava/lang/Object;)I");
			global::java.util.Arrays._hashCode25797 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([D)I");
			global::java.util.Arrays._copyOf25798 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([II)[I");
			global::java.util.Arrays._copyOf25799 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([Ljava/lang/Object;ILjava/lang/Class;)[Ljava/lang/Object;");
			global::java.util.Arrays._copyOf25800 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([FI)[F");
			global::java.util.Arrays._copyOf25801 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([DI)[D");
			global::java.util.Arrays._copyOf25802 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([ZI)[Z");
			global::java.util.Arrays._copyOf25803 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([CI)[C");
			global::java.util.Arrays._copyOf25804 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([JI)[J");
			global::java.util.Arrays._copyOf25805 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([Ljava/lang/Object;I)[Ljava/lang/Object;");
			global::java.util.Arrays._copyOf25806 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([BI)[B");
			global::java.util.Arrays._copyOf25807 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([SI)[S");
			global::java.util.Arrays._copyOfRange25808 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([CII)[C");
			global::java.util.Arrays._copyOfRange25809 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([ZII)[Z");
			global::java.util.Arrays._copyOfRange25810 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([DII)[D");
			global::java.util.Arrays._copyOfRange25811 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([FII)[F");
			global::java.util.Arrays._copyOfRange25812 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([JII)[J");
			global::java.util.Arrays._copyOfRange25813 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([III)[I");
			global::java.util.Arrays._copyOfRange25814 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([SII)[S");
			global::java.util.Arrays._copyOfRange25815 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([BII)[B");
			global::java.util.Arrays._copyOfRange25816 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([Ljava/lang/Object;IILjava/lang/Class;)[Ljava/lang/Object;");
			global::java.util.Arrays._copyOfRange25817 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([Ljava/lang/Object;II)[Ljava/lang/Object;");
			global::java.util.Arrays._fill25818 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([DD)V");
			global::java.util.Arrays._fill25819 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([FF)V");
			global::java.util.Arrays._fill25820 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([FIIF)V");
			global::java.util.Arrays._fill25821 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([ZIIZ)V");
			global::java.util.Arrays._fill25822 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([BIIB)V");
			global::java.util.Arrays._fill25823 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([BB)V");
			global::java.util.Arrays._fill25824 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([CIIC)V");
			global::java.util.Arrays._fill25825 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([SS)V");
			global::java.util.Arrays._fill25826 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([Ljava/lang/Object;IILjava/lang/Object;)V");
			global::java.util.Arrays._fill25827 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.util.Arrays._fill25828 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([CC)V");
			global::java.util.Arrays._fill25829 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([SIIS)V");
			global::java.util.Arrays._fill25830 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([JJ)V");
			global::java.util.Arrays._fill25831 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([JIIJ)V");
			global::java.util.Arrays._fill25832 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([II)V");
			global::java.util.Arrays._fill25833 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([IIII)V");
			global::java.util.Arrays._fill25834 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([ZZ)V");
			global::java.util.Arrays._fill25835 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([DIID)V");
			global::java.util.Arrays._sort25836 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([I)V");
			global::java.util.Arrays._sort25837 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;Ljava/util/Comparator;)V");
			global::java.util.Arrays._sort25838 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;IILjava/util/Comparator;)V");
			global::java.util.Arrays._sort25839 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([JII)V");
			global::java.util.Arrays._sort25840 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([J)V");
			global::java.util.Arrays._sort25841 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([FII)V");
			global::java.util.Arrays._sort25842 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([F)V");
			global::java.util.Arrays._sort25843 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([DII)V");
			global::java.util.Arrays._sort25844 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([D)V");
			global::java.util.Arrays._sort25845 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([BII)V");
			global::java.util.Arrays._sort25846 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([B)V");
			global::java.util.Arrays._sort25847 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([CII)V");
			global::java.util.Arrays._sort25848 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([S)V");
			global::java.util.Arrays._sort25849 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([SII)V");
			global::java.util.Arrays._sort25850 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([III)V");
			global::java.util.Arrays._sort25851 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;)V");
			global::java.util.Arrays._sort25852 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;II)V");
			global::java.util.Arrays._sort25853 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([C)V");
			global::java.util.Arrays._binarySearch25854 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([CC)I");
			global::java.util.Arrays._binarySearch25855 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I");
			global::java.util.Arrays._binarySearch25856 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([SIIS)I");
			global::java.util.Arrays._binarySearch25857 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([SS)I");
			global::java.util.Arrays._binarySearch25858 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([FIIF)I");
			global::java.util.Arrays._binarySearch25859 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([IIII)I");
			global::java.util.Arrays._binarySearch25860 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([II)I");
			global::java.util.Arrays._binarySearch25861 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([FF)I");
			global::java.util.Arrays._binarySearch25862 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([JIIJ)I");
			global::java.util.Arrays._binarySearch25863 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([DD)I");
			global::java.util.Arrays._binarySearch25864 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([JJ)I");
			global::java.util.Arrays._binarySearch25865 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I");
			global::java.util.Arrays._binarySearch25866 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([DIID)I");
			global::java.util.Arrays._binarySearch25867 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;)I");
			global::java.util.Arrays._binarySearch25868 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([BB)I");
			global::java.util.Arrays._binarySearch25869 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([BIIB)I");
			global::java.util.Arrays._binarySearch25870 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;)I");
			global::java.util.Arrays._binarySearch25871 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([CIIC)I");
			global::java.util.Arrays._asList25872 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "asList", "([Ljava/lang/Object;)Ljava/util/List;");
			global::java.util.Arrays._deepHashCode25873 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepHashCode", "([Ljava/lang/Object;)I");
			global::java.util.Arrays._deepEquals25874 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			global::java.util.Arrays._deepToString25875 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepToString", "([Ljava/lang/Object;)Ljava/lang/String;");
		}
	}
}
