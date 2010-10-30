namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParserCursor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParserCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33707;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.ParserCursor._toString33707.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.ParserCursor._toString33707 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._toString33707) as java.lang.String;
		}
		public new int LowerBound
		{
			get
			{
				return getLowerBound();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLowerBound33708;
		public virtual int getLowerBound()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.ParserCursor._getLowerBound33708.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.ParserCursor._getLowerBound33708 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "getLowerBound", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._getLowerBound33708);
		}
		public new int UpperBound
		{
			get
			{
				return getUpperBound();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUpperBound33709;
		public virtual int getUpperBound()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.ParserCursor._getUpperBound33709.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.ParserCursor._getUpperBound33709 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "getUpperBound", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._getUpperBound33709);
		}
		public new int Pos
		{
			get
			{
				return getPos();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPos33710;
		public virtual int getPos()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.ParserCursor._getPos33710.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.ParserCursor._getPos33710 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "getPos", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._getPos33710);
		}
		internal static global::MonoJavaBridge.MethodId _updatePos33711;
		public virtual void updatePos(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.ParserCursor._updatePos33711.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.ParserCursor._updatePos33711 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "updatePos", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._updatePos33711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atEnd33712;
		public virtual bool atEnd()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.ParserCursor._atEnd33712.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.ParserCursor._atEnd33712 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "atEnd", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._atEnd33712);
		}
		internal static global::MonoJavaBridge.MethodId _ParserCursor33713;
		public ParserCursor(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.ParserCursor._ParserCursor33713.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.ParserCursor._ParserCursor33713 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._ParserCursor33713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
