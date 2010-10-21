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
		internal static global::MonoJavaBridge.MethodId _equals13749;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.Pair._equals13749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.Pair.staticClass, global::android.util.Pair._equals13749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13750;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.Pair._hashCode13750);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.Pair.staticClass, global::android.util.Pair._hashCode13750);
		}
		internal static global::MonoJavaBridge.MethodId _create13751;
		public static global::android.util.Pair create(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Pair.staticClass, global::android.util.Pair._create13751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.util.Pair;
		}
		internal static global::MonoJavaBridge.MethodId _Pair13752;
		public Pair(java.lang.Object arg0, java.lang.Object arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Pair.staticClass, global::android.util.Pair._Pair13752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _first13753;
		public global::java.lang.Object first
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _first13753)) as java.lang.Object;
			}
		}
		internal static global::MonoJavaBridge.FieldId _second13754;
		public global::java.lang.Object second
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _second13754)) as java.lang.Object;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Pair.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Pair"));
			global::android.util.Pair._equals13749 = @__env.GetMethodIDNoThrow(global::android.util.Pair.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.util.Pair._hashCode13750 = @__env.GetMethodIDNoThrow(global::android.util.Pair.staticClass, "hashCode", "()I");
			global::android.util.Pair._create13751 = @__env.GetStaticMethodIDNoThrow(global::android.util.Pair.staticClass, "create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroid/util/Pair;");
			global::android.util.Pair._Pair13752 = @__env.GetMethodIDNoThrow(global::android.util.Pair.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::android.util.Pair._first13753 = @__env.GetFieldIDNoThrow(global::android.util.Pair.staticClass, "first", "Ljava/lang/Object;");
			global::android.util.Pair._second13754 = @__env.GetFieldIDNoThrow(global::android.util.Pair.staticClass, "second", "Ljava/lang/Object;");
		}
	}
}
