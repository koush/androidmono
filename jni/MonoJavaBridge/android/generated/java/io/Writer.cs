namespace java.io
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Writer : java.lang.Object, java.lang.Appendable, Closeable, Flushable
	{
		internal static global::java.lang.Class staticClass;
		static Writer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.io.Writer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Writer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12196;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.Writer._append12196, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.Writer.staticClass, global::java.io.Writer._append12196, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12197;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.Writer._append12197, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.Writer.staticClass, global::java.io.Writer._append12197, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12198;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.Writer._append12198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.Writer.staticClass, global::java.io.Writer._append12198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12199;
		public abstract void write(char[] arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _write12200;
		public virtual void write(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.Writer._write12200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.Writer.staticClass, global::java.io.Writer._write12200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12201;
		public virtual void write(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.Writer._write12201, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.Writer.staticClass, global::java.io.Writer._write12201, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12202;
		public virtual void write(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.Writer._write12202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.Writer.staticClass, global::java.io.Writer._write12202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12203;
		public virtual void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.Writer._write12203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.Writer.staticClass, global::java.io.Writer._write12203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush12204;
		public abstract void flush();
		internal static global::net.sf.jni4net.jni.MethodId _close12205;
		public abstract void close();
		internal static global::net.sf.jni4net.jni.MethodId _Writer12206;
		protected Writer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._Writer12206, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Writer12207;
		protected Writer(java.lang.Object arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._Writer12207, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.io.Writer.staticClass = @__class;
			global::java.io.Writer._append12196 = @__env.GetMethodID(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.io.Writer._append12197 = @__env.GetMethodID(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.io.Writer._append12198 = @__env.GetMethodID(global::java.io.Writer.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.io.Writer._write12199 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "([CII)V");
			global::java.io.Writer._write12200 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "(I)V");
			global::java.io.Writer._write12201 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "([C)V");
			global::java.io.Writer._write12202 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;)V");
			global::java.io.Writer._write12203 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.Writer._flush12204 = @__env.GetMethodID(global::java.io.Writer.staticClass, "flush", "()V");
			global::java.io.Writer._close12205 = @__env.GetMethodID(global::java.io.Writer.staticClass, "close", "()V");
			global::java.io.Writer._Writer12206 = @__env.GetMethodID(global::java.io.Writer.staticClass, "<init>", "()V");
			global::java.io.Writer._Writer12207 = @__env.GetMethodID(global::java.io.Writer.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
	}
}
