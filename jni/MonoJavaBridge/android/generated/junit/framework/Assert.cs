namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Assert : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Assert()
		{
			InitJNI();
		}
		protected Assert(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _assertTrue24728;
		public static void assertTrue(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertTrue24728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertTrue24729;
		public static void assertTrue(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertTrue24729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertFalse24730;
		public static void assertFalse(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertFalse24730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertFalse24731;
		public static void assertFalse(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertFalse24731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fail24732;
		public static void fail(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._fail24732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fail24733;
		public static void fail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._fail24733);
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24734;
		public static void assertEquals(java.lang.String arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24735;
		public static void assertEquals(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24736;
		public static void assertEquals(java.lang.String arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24737;
		public static void assertEquals(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24738;
		public static void assertEquals(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24739;
		public static void assertEquals(java.lang.String arg0, byte arg1, byte arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24740;
		public static void assertEquals(byte arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24741;
		public static void assertEquals(java.lang.String arg0, char arg1, char arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24742;
		public static void assertEquals(char arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24743;
		public static void assertEquals(java.lang.String arg0, short arg1, short arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24744;
		public static void assertEquals(short arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24745;
		public static void assertEquals(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24746;
		public static void assertEquals(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24747;
		public static void assertEquals(java.lang.String arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24748;
		public static void assertEquals(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24749;
		public static void assertEquals(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24750;
		public static void assertEquals(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24751;
		public static void assertEquals(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24752;
		public static void assertEquals(java.lang.String arg0, double arg1, double arg2, double arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _assertEquals24753;
		public static void assertEquals(double arg0, double arg1, double arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertEquals24753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotNull24754;
		public static void assertNotNull(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotNull24754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotNull24755;
		public static void assertNotNull(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotNull24755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNull24756;
		public static void assertNull(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNull24756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertNull24757;
		public static void assertNull(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNull24757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertSame24758;
		public static void assertSame(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertSame24758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertSame24759;
		public static void assertSame(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertSame24759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotSame24760;
		public static void assertNotSame(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotSame24760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertNotSame24761;
		public static void assertNotSame(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._assertNotSame24761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Assert24762;
		protected Assert()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.Assert.staticClass, global::junit.framework.Assert._Assert24762);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.Assert.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/Assert"));
			global::junit.framework.Assert._assertTrue24728 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertTrue", "(Ljava/lang/String;Z)V");
			global::junit.framework.Assert._assertTrue24729 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertTrue", "(Z)V");
			global::junit.framework.Assert._assertFalse24730 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertFalse", "(Z)V");
			global::junit.framework.Assert._assertFalse24731 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertFalse", "(Ljava/lang/String;Z)V");
			global::junit.framework.Assert._fail24732 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "fail", "(Ljava/lang/String;)V");
			global::junit.framework.Assert._fail24733 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "fail", "()V");
			global::junit.framework.Assert._assertEquals24734 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;FFF)V");
			global::junit.framework.Assert._assertEquals24735 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(FFF)V");
			global::junit.framework.Assert._assertEquals24736 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;JJ)V");
			global::junit.framework.Assert._assertEquals24737 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(JJ)V");
			global::junit.framework.Assert._assertEquals24738 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(ZZ)V");
			global::junit.framework.Assert._assertEquals24739 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;BB)V");
			global::junit.framework.Assert._assertEquals24740 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(BB)V");
			global::junit.framework.Assert._assertEquals24741 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;CC)V");
			global::junit.framework.Assert._assertEquals24742 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(CC)V");
			global::junit.framework.Assert._assertEquals24743 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;SS)V");
			global::junit.framework.Assert._assertEquals24744 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(SS)V");
			global::junit.framework.Assert._assertEquals24745 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;II)V");
			global::junit.framework.Assert._assertEquals24746 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(II)V");
			global::junit.framework.Assert._assertEquals24747 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;ZZ)V");
			global::junit.framework.Assert._assertEquals24748 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertEquals24749 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertEquals24750 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::junit.framework.Assert._assertEquals24751 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::junit.framework.Assert._assertEquals24752 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;DDD)V");
			global::junit.framework.Assert._assertEquals24753 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(DDD)V");
			global::junit.framework.Assert._assertNotNull24754 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotNull", "(Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertNotNull24755 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotNull", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertNull24756 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNull", "(Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertNull24757 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNull", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertSame24758 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertSame24759 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertSame", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertNotSame24760 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._assertNotSame24761 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotSame", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::junit.framework.Assert._Assert24762 = @__env.GetMethodIDNoThrow(global::junit.framework.Assert.staticClass, "<init>", "()V");
		}
	}
}
