namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Pair : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Pair(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.Pair.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.util.Pair._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.Pair.staticClass, "hashCode", "()I", ref global::android.util.Pair._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.util.Pair create(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Pair._m2.native == global::System.IntPtr.Zero)
				global::android.util.Pair._m2 = @__env.GetStaticMethodIDNoThrow(global::android.util.Pair.staticClass, "create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroid/util/Pair;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Pair.staticClass, global::android.util.Pair._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.util.Pair;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public Pair(java.lang.Object arg0, java.lang.Object arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Pair._m3.native == global::System.IntPtr.Zero)
				global::android.util.Pair._m3 = @__env.GetMethodIDNoThrow(global::android.util.Pair.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Pair.staticClass, global::android.util.Pair._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _first5400;
		public global::java.lang.Object first
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _first5400)) as java.lang.Object;
			}
		}
		internal static global::MonoJavaBridge.FieldId _second5401;
		public global::java.lang.Object second
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _second5401)) as java.lang.Object;
			}
		}
		static Pair()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Pair.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Pair"));
			global::android.util.Pair._first5400 = @__env.GetFieldIDNoThrow(global::android.util.Pair.staticClass, "first", "Ljava/lang/Object;");
			global::android.util.Pair._second5401 = @__env.GetFieldIDNoThrow(global::android.util.Pair.staticClass, "second", "Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
