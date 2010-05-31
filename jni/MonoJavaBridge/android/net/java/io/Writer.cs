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
		internal static global::net.sf.jni4net.jni.MethodId _append11467; 
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.Writer._append11467, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.Writer.staticClass, global::java.io.Writer._append11467, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append11468; 
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.Writer._append11468, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.Writer.staticClass, global::java.io.Writer._append11468, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append11469; 
		public virtual global::java.lang.Appendable append(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.Writer._append11469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.Writer.staticClass, global::java.io.Writer._append11469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write11470; 
		public abstract void write(char[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _write11471; 
		public virtual void write(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.io.Writer._write11471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.io.Writer.staticClass, global::java.io.Writer._write11471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write11472; 
		public virtual void write(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.io.Writer._write11472, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.io.Writer.staticClass, global::java.io.Writer._write11472, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write11473; 
		public virtual void write(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.io.Writer._write11473, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.io.Writer.staticClass, global::java.io.Writer._write11473, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write11474; 
		public virtual void write(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.io.Writer._write11474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.io.Writer.staticClass, global::java.io.Writer._write11474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flush11475; 
		public abstract void flush(); 
		internal static global::net.sf.jni4net.jni.MethodId _close11476; 
		public abstract void close(); 
		internal static global::net.sf.jni4net.jni.MethodId _Writer11477; 
		protected Writer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._Writer11477, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Writer11478; 
		protected Writer(java.lang.Object arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._Writer11478, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.io.Writer.staticClass = @__class; 
			global::java.io.Writer._append11467 = @__env.GetMethodID(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;"); 
			global::java.io.Writer._append11468 = @__env.GetMethodID(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;"); 
			global::java.io.Writer._append11469 = @__env.GetMethodID(global::java.io.Writer.staticClass, "append", "(C)Ljava/lang/Appendable;"); 
			global::java.io.Writer._write11470 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "([CII)V"); 
			global::java.io.Writer._write11471 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "(I)V"); 
			global::java.io.Writer._write11472 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "([C)V"); 
			global::java.io.Writer._write11473 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;)V"); 
			global::java.io.Writer._write11474 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;II)V"); 
			global::java.io.Writer._flush11475 = @__env.GetMethodID(global::java.io.Writer.staticClass, "flush", "()V"); 
			global::java.io.Writer._close11476 = @__env.GetMethodID(global::java.io.Writer.staticClass, "close", "()V"); 
			global::java.io.Writer._Writer11477 = @__env.GetMethodID(global::java.io.Writer.staticClass, "<init>", "()V"); 
			global::java.io.Writer._Writer11478 = @__env.GetMethodID(global::java.io.Writer.staticClass, "<init>", "(Ljava/lang/Object;)V"); 
		} 
	} 
	public static class WriterExtensionMethods 
	{ 
		public static java.lang.Appendable append(this global::java.io.Writer __this, string arg0) 
		{ 
			return __this.append((global::java.lang.String)arg0); 
		} 
		public static java.lang.Appendable append(this global::java.io.Writer __this, string arg0, int arg1, int arg2) 
		{ 
			return __this.append((global::java.lang.String)arg0, arg1, arg2); 
		} 
	} 
} 
