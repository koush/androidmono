namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParserCursor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParserCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.ParserCursor.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.message.ParserCursor._m0) as java.lang.String;
		}
		public new int LowerBound
		{
			get
			{
				return getLowerBound();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getLowerBound()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.ParserCursor.staticClass, "getLowerBound", "()I", ref global::org.apache.http.message.ParserCursor._m1);
		}
		public new int UpperBound
		{
			get
			{
				return getUpperBound();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getUpperBound()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.ParserCursor.staticClass, "getUpperBound", "()I", ref global::org.apache.http.message.ParserCursor._m2);
		}
		public new int Pos
		{
			get
			{
				return getPos();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getPos()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.ParserCursor.staticClass, "getPos", "()I", ref global::org.apache.http.message.ParserCursor._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void updatePos(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.ParserCursor.staticClass, "updatePos", "(I)V", ref global::org.apache.http.message.ParserCursor._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool atEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.ParserCursor.staticClass, "atEnd", "()Z", ref global::org.apache.http.message.ParserCursor._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ParserCursor(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.ParserCursor._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.ParserCursor._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ParserCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.ParserCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/ParserCursor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
