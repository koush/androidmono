namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.Dictionary_))]
	public abstract partial class Dictionary : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Dictionary(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.Object get(java.lang.Object arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract bool isEmpty();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract int size();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.lang.Object remove(java.lang.Object arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.util.Enumeration elements();
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.util.Enumeration keys();
		private static global::MonoJavaBridge.MethodId _m7;
		public Dictionary() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Dictionary._m7.native == global::System.IntPtr.Zero)
				global::java.util.Dictionary._m7 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Dictionary.staticClass, global::java.util.Dictionary._m7);
			Init(@__env, handle);
		}
		static Dictionary()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Dictionary.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Dictionary"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Dictionary))]
	internal sealed partial class Dictionary_ : java.util.Dictionary
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Dictionary_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Dictionary_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Dictionary_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Dictionary_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Dictionary_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Dictionary_.staticClass, "isEmpty", "()Z", ref global::java.util.Dictionary_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Dictionary_.staticClass, "size", "()I", ref global::java.util.Dictionary_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Dictionary_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Dictionary_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.util.Enumeration elements()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.Dictionary_.staticClass, "elements", "()Ljava/util/Enumeration;", ref global::java.util.Dictionary_._m5) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.Enumeration keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.Dictionary_.staticClass, "keys", "()Ljava/util/Enumeration;", ref global::java.util.Dictionary_._m6) as java.util.Enumeration;
		}
		static Dictionary_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Dictionary_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Dictionary"));
		}
	}
}
