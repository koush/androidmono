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
		internal static global::MonoJavaBridge.MethodId _input32975;
		public virtual void input(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input32975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input32975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _input32976;
		public virtual void input(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input32976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input32976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _input32977;
		public virtual void input(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input32977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input32977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _input32978;
		public virtual void input(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input32978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input32978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _input32979;
		public virtual void input(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._input32979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._input32979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output32980;
		public virtual void output(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output32980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output32980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output32981;
		public virtual void output(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output32981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output32981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output32982;
		public virtual void output(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output32982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output32982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output32983;
		public virtual void output(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output32983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output32983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _output32984;
		public virtual void output(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._output32984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._output32984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _enabled32985;
		public virtual bool enabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire._enabled32985);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._enabled32985);
		}
		internal static global::MonoJavaBridge.MethodId _Wire32986;
		public Wire(org.apache.commons.logging.Log arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.Wire.staticClass, global::org.apache.http.impl.conn.Wire._Wire32986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.Wire.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/Wire"));
			global::org.apache.http.impl.conn.Wire._input32975 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.conn.Wire._input32976 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "(Ljava/io/InputStream;)V");
			global::org.apache.http.impl.conn.Wire._input32977 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "([BII)V");
			global::org.apache.http.impl.conn.Wire._input32978 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "([B)V");
			global::org.apache.http.impl.conn.Wire._input32979 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "input", "(I)V");
			global::org.apache.http.impl.conn.Wire._output32980 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "([B)V");
			global::org.apache.http.impl.conn.Wire._output32981 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.conn.Wire._output32982 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "(Ljava/io/InputStream;)V");
			global::org.apache.http.impl.conn.Wire._output32983 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "(I)V");
			global::org.apache.http.impl.conn.Wire._output32984 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "output", "([BII)V");
			global::org.apache.http.impl.conn.Wire._enabled32985 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "enabled", "()Z");
			global::org.apache.http.impl.conn.Wire._Wire32986 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.Wire.staticClass, "<init>", "(Lorg/apache/commons/logging/Log;)V");
		}
	}
}
