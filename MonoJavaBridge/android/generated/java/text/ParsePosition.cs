namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParsePosition : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParsePosition(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.ParsePosition.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.ParsePosition._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.ParsePosition.staticClass, "toString", "()Ljava/lang/String;", ref global::java.text.ParsePosition._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.ParsePosition.staticClass, "hashCode", "()I", ref global::java.text.ParsePosition._m2);
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
			set
			{
				setIndex(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.ParsePosition.staticClass, "getIndex", "()I", ref global::java.text.ParsePosition._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.ParsePosition.staticClass, "setIndex", "(I)V", ref global::java.text.ParsePosition._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setErrorIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.ParsePosition.staticClass, "setErrorIndex", "(I)V", ref global::java.text.ParsePosition._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ErrorIndex
		{
			get
			{
				return getErrorIndex();
			}
			set
			{
				setErrorIndex(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getErrorIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.ParsePosition.staticClass, "getErrorIndex", "()I", ref global::java.text.ParsePosition._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ParsePosition(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.ParsePosition._m7.native == global::System.IntPtr.Zero)
				global::java.text.ParsePosition._m7 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ParsePosition.staticClass, global::java.text.ParsePosition._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ParsePosition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ParsePosition.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ParsePosition"));
		}
	}
}
