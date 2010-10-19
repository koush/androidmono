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
		internal static global::MonoJavaBridge.MethodId _toString26958;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._toString26958)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._toString26958)) as java.lang.String;
		}
		public new int LowerBound
		{
			get
			{
				return getLowerBound();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLowerBound26959;
		public virtual int getLowerBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._getLowerBound26959);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._getLowerBound26959);
		}
		public new int UpperBound
		{
			get
			{
				return getUpperBound();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUpperBound26960;
		public virtual int getUpperBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._getUpperBound26960);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._getUpperBound26960);
		}
		public new int Pos
		{
			get
			{
				return getPos();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPos26961;
		public virtual int getPos() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._getPos26961);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._getPos26961);
		}
		internal static global::MonoJavaBridge.MethodId _updatePos26962;
		public virtual void updatePos(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._updatePos26962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._updatePos26962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atEnd26963;
		public virtual bool atEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor._atEnd26963);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._atEnd26963);
		}
		internal static global::MonoJavaBridge.MethodId _ParserCursor26964;
		public ParserCursor(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.ParserCursor.staticClass, global::org.apache.http.message.ParserCursor._ParserCursor26964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.ParserCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/ParserCursor"));
			global::org.apache.http.message.ParserCursor._toString26958 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.ParserCursor._getLowerBound26959 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "getLowerBound", "()I");
			global::org.apache.http.message.ParserCursor._getUpperBound26960 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "getUpperBound", "()I");
			global::org.apache.http.message.ParserCursor._getPos26961 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "getPos", "()I");
			global::org.apache.http.message.ParserCursor._updatePos26962 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "updatePos", "(I)V");
			global::org.apache.http.message.ParserCursor._atEnd26963 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "atEnd", "()Z");
			global::org.apache.http.message.ParserCursor._ParserCursor26964 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.ParserCursor.staticClass, "<init>", "(II)V");
		}
	}
}
