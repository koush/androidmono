namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParserCursor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParserCursor()
		{
			InitJNI();
		}
		protected ParserCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33706;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._toString33706)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._toString33706)) as java.lang.String;
		}
		public new int LowerBound
		{
			get
			{
				return getLowerBound();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLowerBound33707;
		public virtual int getLowerBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._getLowerBound33707);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._getLowerBound33707);
		}
		public new int UpperBound
		{
			get
			{
				return getUpperBound();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUpperBound33708;
		public virtual int getUpperBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._getUpperBound33708);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._getUpperBound33708);
		}
		public new int Pos
		{
			get
			{
				return getPos();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPos33709;
		public virtual int getPos() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._getPos33709);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._getPos33709);
		}
		internal static global::MonoJavaBridge.MethodId _updatePos33710;
		public virtual void updatePos(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._updatePos33710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._updatePos33710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atEnd33711;
		public virtual bool atEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._atEnd33711);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._atEnd33711);
		}
		internal static global::MonoJavaBridge.MethodId _ParserCursor33712;
		public ParserCursor(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._ParserCursor33712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.ParserCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/ParserCursor"));
			global::org.apache.http.message.ParserCursor._toString33706 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.ParserCursor._getLowerBound33707 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "getLowerBound", "()I");
			global::org.apache.http.message.ParserCursor._getUpperBound33708 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "getUpperBound", "()I");
			global::org.apache.http.message.ParserCursor._getPos33709 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "getPos", "()I");
			global::org.apache.http.message.ParserCursor._updatePos33710 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "updatePos", "(I)V");
			global::org.apache.http.message.ParserCursor._atEnd33711 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "atEnd", "()Z");
			global::org.apache.http.message.ParserCursor._ParserCursor33712 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "<init>", "(II)V");
		}
	}
}
