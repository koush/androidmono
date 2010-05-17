namespace java.io 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Writer : java.lang.Object, java.lang.Appendable, Closeable, Flushable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Writer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.io.Writer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Writer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append10644; 
		public virtual java.lang.Appendable append(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Writer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, _append10644, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.Writer.staticClass, _append10644, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append10645; 
		public virtual java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Writer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, _append10645, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.Writer.staticClass, _append10645, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append10646; 
		public virtual java.lang.Appendable append(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Writer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, _append10646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.Writer.staticClass, _append10646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10647; 
		public abstract void write(char[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _write10648; 
		public virtual void write(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Writer)) 
				@__env.CallVoidMethod(this, _write10648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.Writer.staticClass, _write10648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10649; 
		public virtual void write(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Writer)) 
				@__env.CallVoidMethod(this, _write10649, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.Writer.staticClass, _write10649, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10650; 
		public virtual void write(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Writer)) 
				@__env.CallVoidMethod(this, _write10650, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.Writer.staticClass, _write10650, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10651; 
		public virtual void write(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.Writer)) 
				@__env.CallVoidMethod(this, _write10651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.Writer.staticClass, _write10651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flush10652; 
		public abstract void flush(); 
		internal static global::net.sf.jni4net.jni.MethodId _close10653; 
		public abstract void close(); 
		internal static global::net.sf.jni4net.jni.MethodId _Writer10654; 
		protected Writer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.Writer.staticClass, _Writer10654, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Writer10655; 
		protected Writer(java.lang.Object arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.Writer.staticClass, _Writer10655, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.io.Writer.staticClass = @__class; 
			global::java.io.Writer._append10644 = @__env.GetMethodID(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;"); 
			global::java.io.Writer._append10645 = @__env.GetMethodID(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;"); 
			global::java.io.Writer._append10646 = @__env.GetMethodID(global::java.io.Writer.staticClass, "append", "(C)Ljava/lang/Appendable;"); 
			global::java.io.Writer._write10647 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "([CII)V"); 
			global::java.io.Writer._write10648 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "(I)V"); 
			global::java.io.Writer._write10649 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "([C)V"); 
			global::java.io.Writer._write10650 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;)V"); 
			global::java.io.Writer._write10651 = @__env.GetMethodID(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;II)V"); 
			global::java.io.Writer._flush10652 = @__env.GetMethodID(global::java.io.Writer.staticClass, "flush", "()V"); 
			global::java.io.Writer._close10653 = @__env.GetMethodID(global::java.io.Writer.staticClass, "close", "()V"); 
			global::java.io.Writer._Writer10654 = @__env.GetMethodID(global::java.io.Writer.staticClass, "<init>", "()V"); 
			global::java.io.Writer._Writer10655 = @__env.GetMethodID(global::java.io.Writer.staticClass, "<init>", "(Ljava/lang/Object;)V"); 
		} 
	} 
} 
