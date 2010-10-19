namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Wire : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Wire()
		{
			InitJNI();
		}
		protected Wire(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _input26351;
		public virtual void input(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input26351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input26351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _input26352;
		public virtual void input(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input26352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input26352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _input26353;
		public virtual void input(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input26353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input26353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _input26354;
		public virtual void input(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input26354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input26354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _input26355;
		public virtual void input(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input26355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input26355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output26356;
		public virtual void output(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output26356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output26356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output26357;
		public virtual void output(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output26357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output26357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output26358;
		public virtual void output(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output26358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output26358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output26359;
		public virtual void output(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output26359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output26359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output26360;
		public virtual void output(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output26360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output26360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _enabled26361;
		public virtual bool enabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._enabled26361);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._enabled26361);
		}
		internal static global::MonoJavaBridge.MethodId _Wire26362;
		public Wire(org.apache.commons.logging.Log arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._Wire26362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.Wire.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/Wire"));
			global::org.apache.http.impl.conn.Wire._input26351 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.conn.Wire._input26352 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "(Ljava/io/InputStream;)V");
			global::org.apache.http.impl.conn.Wire._input26353 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "([BII)V");
			global::org.apache.http.impl.conn.Wire._input26354 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "([B)V");
			global::org.apache.http.impl.conn.Wire._input26355 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "(I)V");
			global::org.apache.http.impl.conn.Wire._output26356 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "([B)V");
			global::org.apache.http.impl.conn.Wire._output26357 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.conn.Wire._output26358 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "(Ljava/io/InputStream;)V");
			global::org.apache.http.impl.conn.Wire._output26359 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "(I)V");
			global::org.apache.http.impl.conn.Wire._output26360 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "([BII)V");
			global::org.apache.http.impl.conn.Wire._enabled26361 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "enabled", "()Z");
			global::org.apache.http.impl.conn.Wire._Wire26362 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "<init>", "(Lorg/apache/commons/logging/Log;)V");
		}
	}
}
