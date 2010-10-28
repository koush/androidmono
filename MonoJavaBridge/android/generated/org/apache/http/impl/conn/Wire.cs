namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Wire : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Wire(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _input33094;
		public virtual void input(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input33094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input33094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _input33095;
		public virtual void input(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input33095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input33095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _input33096;
		public virtual void input(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input33096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input33096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _input33097;
		public virtual void input(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input33097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input33097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _input33098;
		public virtual void input(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input33098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input33098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output33099;
		public virtual void output(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output33099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output33099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output33100;
		public virtual void output(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output33100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output33100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output33101;
		public virtual void output(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output33101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output33101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output33102;
		public virtual void output(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output33102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output33102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output33103;
		public virtual void output(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output33103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output33103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _enabled33104;
		public virtual bool enabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._enabled33104);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._enabled33104);
		}
		internal static global::MonoJavaBridge.MethodId _Wire33105;
		public Wire(org.apache.commons.logging.Log arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._Wire33105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Wire()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.Wire.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/Wire"));
			global::org.apache.http.impl.conn.Wire._input33094 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.conn.Wire._input33095 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "(Ljava/io/InputStream;)V");
			global::org.apache.http.impl.conn.Wire._input33096 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "([BII)V");
			global::org.apache.http.impl.conn.Wire._input33097 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "([B)V");
			global::org.apache.http.impl.conn.Wire._input33098 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "(I)V");
			global::org.apache.http.impl.conn.Wire._output33099 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "([B)V");
			global::org.apache.http.impl.conn.Wire._output33100 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.conn.Wire._output33101 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "(Ljava/io/InputStream;)V");
			global::org.apache.http.impl.conn.Wire._output33102 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "(I)V");
			global::org.apache.http.impl.conn.Wire._output33103 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "([BII)V");
			global::org.apache.http.impl.conn.Wire._enabled33104 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "enabled", "()Z");
			global::org.apache.http.impl.conn.Wire._Wire33105 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "<init>", "(Lorg/apache/commons/logging/Log;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
