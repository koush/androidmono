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
		internal static global::MonoJavaBridge.MethodId _equals19876;
		public static bool equals(java.lang.Object[] arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals19876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals19877;
		public static bool equals(float[] arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals19877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals19878;
		public static bool equals(double[] arg0, double[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals19878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals19879;
		public static bool equals(bool[] arg0, bool[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals19879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals19880;
		public static bool equals(byte[] arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals19880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals19881;
		public static bool equals(char[] arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals19881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals19882;
		public static bool equals(short[] arg0, short[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals19882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals19883;
		public static bool equals(int[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals19883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals19884;
		public static bool equals(long[] arg0, long[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._equals19884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString19885;
		public static global::java.lang.String toString(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString19885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19886;
		public static global::java.lang.String toString(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString19886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19887;
		public static global::java.lang.String toString(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString19887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19888;
		public static global::java.lang.String toString(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString19888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19889;
		public static global::java.lang.String toString(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString19889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19890;
		public static global::java.lang.String toString(bool[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString19890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19891;
		public static global::java.lang.String toString(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString19891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19892;
		public static global::java.lang.String toString(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString19892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19893;
		public static global::java.lang.String toString(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._toString19893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19894;
		public static int hashCode(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode19894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19895;
		public static int hashCode(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode19895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19896;
		public static int hashCode(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode19896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19897;
		public static int hashCode(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode19897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19898;
		public static int hashCode(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode19898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19899;
		public static int hashCode(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode19899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19900;
		public static int hashCode(bool[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode19900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19901;
		public static int hashCode(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode19901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19902;
		public static int hashCode(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._hashCode19902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyOf19903;
		public static int[] copyOf(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf19903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf19904;
		public static global::java.lang.Object[] copyOf(java.lang.Object[] arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf19904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf19905;
		public static float[] copyOf(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf19905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf19906;
		public static double[] copyOf(double[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf19906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf19907;
		public static bool[] copyOf(bool[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf19907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf19908;
		public static char[] copyOf(char[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf19908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf19909;
		public static long[] copyOf(long[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf19909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf19910;
		public static global::java.lang.Object[] copyOf(java.lang.Object[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf19910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf19911;
		public static byte[] copyOf(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf19911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOf19912;
		public static short[] copyOf(short[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOf19912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange19913;
		public static char[] copyOfRange(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange19913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange19914;
		public static bool[] copyOfRange(bool[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange19914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange19915;
		public static double[] copyOfRange(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange19915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange19916;
		public static float[] copyOfRange(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange19916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange19917;
		public static long[] copyOfRange(long[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange19917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange19918;
		public static int[] copyOfRange(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange19918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange19919;
		public static short[] copyOfRange(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange19919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange19920;
		public static byte[] copyOfRange(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange19920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange19921;
		public static global::java.lang.Object[] copyOfRange(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Class arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange19921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _copyOfRange19922;
		public static global::java.lang.Object[] copyOfRange(java.lang.Object[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._copyOfRange19922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _fill19923;
		public static void fill(double[] arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill19924;
		public static void fill(float[] arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill19925;
		public static void fill(float[] arg0, int arg1, int arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill19926;
		public static void fill(bool[] arg0, int arg1, int arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill19927;
		public static void fill(byte[] arg0, int arg1, int arg2, byte arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill19928;
		public static void fill(byte[] arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill19929;
		public static void fill(char[] arg0, int arg1, int arg2, char arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill19930;
		public static void fill(short[] arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill19931;
		public static void fill(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill19932;
		public static void fill(java.lang.Object[] arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill19933;
		public static void fill(char[] arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill19934;
		public static void fill(short[] arg0, int arg1, int arg2, short arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill19935;
		public static void fill(long[] arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill19936;
		public static void fill(long[] arg0, int arg1, int arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill19937;
		public static void fill(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill19938;
		public static void fill(int[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fill19939;
		public static void fill(bool[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fill19940;
		public static void fill(double[] arg0, int arg1, int arg2, double arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._fill19940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _sort19941;
		public static void sort(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort19942;
		public static void sort(java.lang.Object[] arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sort19943;
		public static void sort(java.lang.Object[] arg0, int arg1, int arg2, java.util.Comparator arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _sort19944;
		public static void sort(long[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort19945;
		public static void sort(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort19946;
		public static void sort(float[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort19947;
		public static void sort(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort19948;
		public static void sort(double[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort19949;
		public static void sort(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort19950;
		public static void sort(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort19951;
		public static void sort(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort19952;
		public static void sort(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort19953;
		public static void sort(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort19954;
		public static void sort(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort19955;
		public static void sort(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort19956;
		public static void sort(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort19957;
		public static void sort(java.lang.Object[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sort19958;
		public static void sort(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._sort19958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19959;
		public static int binarySearch(char[] arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19960;
		public static int binarySearch(java.lang.Object[] arg0, java.lang.Object arg1, java.util.Comparator arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19961;
		public static int binarySearch(short[] arg0, int arg1, int arg2, short arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19962;
		public static int binarySearch(short[] arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19963;
		public static int binarySearch(float[] arg0, int arg1, int arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19964;
		public static int binarySearch(int[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19965;
		public static int binarySearch(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19966;
		public static int binarySearch(float[] arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19967;
		public static int binarySearch(long[] arg0, int arg1, int arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19968;
		public static int binarySearch(double[] arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19969;
		public static int binarySearch(long[] arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19970;
		public static int binarySearch(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3, java.util.Comparator arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19971;
		public static int binarySearch(double[] arg0, int arg1, int arg2, double arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19972;
		public static int binarySearch(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19973;
		public static int binarySearch(byte[] arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19974;
		public static int binarySearch(byte[] arg0, int arg1, int arg2, byte arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19975;
		public static int binarySearch(java.lang.Object[] arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch19976;
		public static int binarySearch(char[] arg0, int arg1, int arg2, char arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._binarySearch19976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _asList19977;
		public static global::java.util.List asList(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._asList19977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _deepHashCode19978;
		public static int deepHashCode(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._deepHashCode19978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deepEquals19979;
		public static bool deepEquals(java.lang.Object[] arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._deepEquals19979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deepToString19980;
		public static global::java.lang.String deepToString(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._deepToString19980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Arrays.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Arrays"));
			global::java.util.Arrays._equals19876 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			global::java.util.Arrays._equals19877 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([F[F)Z");
			global::java.util.Arrays._equals19878 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([D[D)Z");
			global::java.util.Arrays._equals19879 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([Z[Z)Z");
			global::java.util.Arrays._equals19880 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([B[B)Z");
			global::java.util.Arrays._equals19881 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([C[C)Z");
			global::java.util.Arrays._equals19882 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([S[S)Z");
			global::java.util.Arrays._equals19883 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([I[I)Z");
			global::java.util.Arrays._equals19884 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([J[J)Z");
			global::java.util.Arrays._toString19885 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([Ljava/lang/Object;)Ljava/lang/String;");
			global::java.util.Arrays._toString19886 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([I)Ljava/lang/String;");
			global::java.util.Arrays._toString19887 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([S)Ljava/lang/String;");
			global::java.util.Arrays._toString19888 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([C)Ljava/lang/String;");
			global::java.util.Arrays._toString19889 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([B)Ljava/lang/String;");
			global::java.util.Arrays._toString19890 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([Z)Ljava/lang/String;");
			global::java.util.Arrays._toString19891 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([F)Ljava/lang/String;");
			global::java.util.Arrays._toString19892 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([D)Ljava/lang/String;");
			global::java.util.Arrays._toString19893 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([J)Ljava/lang/String;");
			global::java.util.Arrays._hashCode19894 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([F)I");
			global::java.util.Arrays._hashCode19895 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([J)I");
			global::java.util.Arrays._hashCode19896 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([I)I");
			global::java.util.Arrays._hashCode19897 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([S)I");
			global::java.util.Arrays._hashCode19898 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([C)I");
			global::java.util.Arrays._hashCode19899 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([B)I");
			global::java.util.Arrays._hashCode19900 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([Z)I");
			global::java.util.Arrays._hashCode19901 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([Ljava/lang/Object;)I");
			global::java.util.Arrays._hashCode19902 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([D)I");
			global::java.util.Arrays._copyOf19903 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([II)[I");
			global::java.util.Arrays._copyOf19904 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([Ljava/lang/Object;ILjava/lang/Class;)[Ljava/lang/Object;");
			global::java.util.Arrays._copyOf19905 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([FI)[F");
			global::java.util.Arrays._copyOf19906 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([DI)[D");
			global::java.util.Arrays._copyOf19907 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([ZI)[Z");
			global::java.util.Arrays._copyOf19908 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([CI)[C");
			global::java.util.Arrays._copyOf19909 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([JI)[J");
			global::java.util.Arrays._copyOf19910 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([Ljava/lang/Object;I)[Ljava/lang/Object;");
			global::java.util.Arrays._copyOf19911 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([BI)[B");
			global::java.util.Arrays._copyOf19912 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([SI)[S");
			global::java.util.Arrays._copyOfRange19913 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([CII)[C");
			global::java.util.Arrays._copyOfRange19914 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([ZII)[Z");
			global::java.util.Arrays._copyOfRange19915 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([DII)[D");
			global::java.util.Arrays._copyOfRange19916 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([FII)[F");
			global::java.util.Arrays._copyOfRange19917 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([JII)[J");
			global::java.util.Arrays._copyOfRange19918 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([III)[I");
			global::java.util.Arrays._copyOfRange19919 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([SII)[S");
			global::java.util.Arrays._copyOfRange19920 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([BII)[B");
			global::java.util.Arrays._copyOfRange19921 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([Ljava/lang/Object;IILjava/lang/Class;)[Ljava/lang/Object;");
			global::java.util.Arrays._copyOfRange19922 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([Ljava/lang/Object;II)[Ljava/lang/Object;");
			global::java.util.Arrays._fill19923 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([DD)V");
			global::java.util.Arrays._fill19924 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([FF)V");
			global::java.util.Arrays._fill19925 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([FIIF)V");
			global::java.util.Arrays._fill19926 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([ZIIZ)V");
			global::java.util.Arrays._fill19927 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([BIIB)V");
			global::java.util.Arrays._fill19928 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([BB)V");
			global::java.util.Arrays._fill19929 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([CIIC)V");
			global::java.util.Arrays._fill19930 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([SS)V");
			global::java.util.Arrays._fill19931 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([Ljava/lang/Object;IILjava/lang/Object;)V");
			global::java.util.Arrays._fill19932 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.util.Arrays._fill19933 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([CC)V");
			global::java.util.Arrays._fill19934 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([SIIS)V");
			global::java.util.Arrays._fill19935 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([JJ)V");
			global::java.util.Arrays._fill19936 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([JIIJ)V");
			global::java.util.Arrays._fill19937 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([II)V");
			global::java.util.Arrays._fill19938 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([IIII)V");
			global::java.util.Arrays._fill19939 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([ZZ)V");
			global::java.util.Arrays._fill19940 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([DIID)V");
			global::java.util.Arrays._sort19941 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([I)V");
			global::java.util.Arrays._sort19942 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;Ljava/util/Comparator;)V");
			global::java.util.Arrays._sort19943 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;IILjava/util/Comparator;)V");
			global::java.util.Arrays._sort19944 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([JII)V");
			global::java.util.Arrays._sort19945 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([J)V");
			global::java.util.Arrays._sort19946 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([FII)V");
			global::java.util.Arrays._sort19947 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([F)V");
			global::java.util.Arrays._sort19948 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([DII)V");
			global::java.util.Arrays._sort19949 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([D)V");
			global::java.util.Arrays._sort19950 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([BII)V");
			global::java.util.Arrays._sort19951 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([B)V");
			global::java.util.Arrays._sort19952 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([CII)V");
			global::java.util.Arrays._sort19953 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([S)V");
			global::java.util.Arrays._sort19954 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([SII)V");
			global::java.util.Arrays._sort19955 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([III)V");
			global::java.util.Arrays._sort19956 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;)V");
			global::java.util.Arrays._sort19957 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;II)V");
			global::java.util.Arrays._sort19958 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([C)V");
			global::java.util.Arrays._binarySearch19959 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([CC)I");
			global::java.util.Arrays._binarySearch19960 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I");
			global::java.util.Arrays._binarySearch19961 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([SIIS)I");
			global::java.util.Arrays._binarySearch19962 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([SS)I");
			global::java.util.Arrays._binarySearch19963 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([FIIF)I");
			global::java.util.Arrays._binarySearch19964 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([IIII)I");
			global::java.util.Arrays._binarySearch19965 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([II)I");
			global::java.util.Arrays._binarySearch19966 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([FF)I");
			global::java.util.Arrays._binarySearch19967 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([JIIJ)I");
			global::java.util.Arrays._binarySearch19968 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([DD)I");
			global::java.util.Arrays._binarySearch19969 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([JJ)I");
			global::java.util.Arrays._binarySearch19970 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I");
			global::java.util.Arrays._binarySearch19971 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([DIID)I");
			global::java.util.Arrays._binarySearch19972 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;)I");
			global::java.util.Arrays._binarySearch19973 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([BB)I");
			global::java.util.Arrays._binarySearch19974 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([BIIB)I");
			global::java.util.Arrays._binarySearch19975 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;)I");
			global::java.util.Arrays._binarySearch19976 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([CIIC)I");
			global::java.util.Arrays._asList19977 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "asList", "([Ljava/lang/Object;)Ljava/util/List;");
			global::java.util.Arrays._deepHashCode19978 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepHashCode", "([Ljava/lang/Object;)I");
			global::java.util.Arrays._deepEquals19979 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			global::java.util.Arrays._deepToString19980 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepToString", "([Ljava/lang/Object;)Ljava/lang/String;");
		}
	}
}
