namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Pair : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Pair()
		{
			InitJNI();
		}
		protected Pair(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals9103;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.Pair._equals9103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.Pair.staticClass, global::android.util.Pair._equals9103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode9104;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.Pair._hashCode9104);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.Pair.staticClass, global::android.util.Pair._hashCode9104);
		}
		internal static global::MonoJavaBridge.MethodId _create9105;
		public static global::android.util.Pair create(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Pair.staticClass, global::android.util.Pair._create9105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.util.Pair;
		}
		internal static global::MonoJavaBridge.MethodId _Pair9106;
		public Pair(java.lang.Object arg0, java.lang.Object arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Pair.staticClass, global::android.util.Pair._Pair9106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _first9107;
		public global::java.lang.Object first
		{
			get
			{
				return default(global::java.lang.Object);
			}
		}
		internal static global::MonoJavaBridge.FieldId _second9108;
		public global::java.lang.Object second
		{
			get
			{
				return default(global::java.lang.Object);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Pair.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Pair"));
			global::android.util.Pair._equals9103 = @__env.GetMethodIDNoThrow(global::android.util.Pair.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.util.Pair._hashCode9104 = @__env.GetMethodIDNoThrow(global::android.util.Pair.staticClass, "hashCode", "()I");
			global::android.util.Pair._create9105 = @__env.GetStaticMethodIDNoThrow(global::android.util.Pair.staticClass, "create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroid/util/Pair;");
			global::android.util.Pair._Pair9106 = @__env.GetMethodIDNoThrow(global::android.util.Pair.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V");
		}
	}
}
