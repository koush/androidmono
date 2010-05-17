namespace java.io 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PrintWriter : java.io.Writer
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PrintWriter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.io.PrintWriter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.io.PrintWriter(@__env); 
			} 
		} 
		protected PrintWriter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println10588; 
		public virtual void println(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _println10588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _println10588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println10589; 
		public virtual void println() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _println10589); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _println10589); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println10590; 
		public virtual void println(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _println10590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _println10590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println10591; 
		public virtual void println(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _println10591, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _println10591, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println10592; 
		public virtual void println(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _println10592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _println10592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println10593; 
		public virtual void println(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _println10593, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _println10593, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println10594; 
		public virtual void println(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _println10594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _println10594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println10595; 
		public virtual void println(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _println10595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _println10595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println10596; 
		public virtual void println(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _println10596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _println10596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println10597; 
		public virtual void println(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _println10597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _println10597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append10598; 
		public virtual new java.io.PrintWriter append(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, _append10598, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.PrintWriter.staticClass, _append10598, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append10599; 
		public virtual new java.io.PrintWriter append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, _append10599, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.PrintWriter.staticClass, _append10599, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append10600; 
		public virtual new java.io.PrintWriter append(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, _append10600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.PrintWriter.staticClass, _append10600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format10601; 
		public virtual java.io.PrintWriter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, _format10601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.PrintWriter.staticClass, _format10601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format10602; 
		public virtual java.io.PrintWriter format(java.lang.String arg0, java.lang.Object[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, _format10602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.PrintWriter.staticClass, _format10602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10603; 
		public override void write(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _write10603, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _write10603, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10604; 
		public override void write(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _write10604, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _write10604, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10605; 
		public override void write(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _write10605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _write10605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10606; 
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _write10606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _write10606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write10607; 
		public override void write(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _write10607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _write10607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _print10608; 
		public virtual void print(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _print10608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _print10608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _print10609; 
		public virtual void print(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _print10609, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _print10609, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _print10610; 
		public virtual void print(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _print10610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _print10610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _print10611; 
		public virtual void print(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _print10611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _print10611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _print10612; 
		public virtual void print(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _print10612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _print10612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _print10613; 
		public virtual void print(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _print10613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _print10613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _print10614; 
		public virtual void print(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _print10614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _print10614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _print10615; 
		public virtual void print(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _print10615, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _print10615, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _print10616; 
		public virtual void print(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _print10616, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _print10616, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flush10617; 
		public override void flush() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _flush10617); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _flush10617); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close10618; 
		public override void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _close10618); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _close10618); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkError10619; 
		public virtual bool checkError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				return @__env.CallBooleanMethod(this, _checkError10619); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.io.PrintWriter.staticClass, _checkError10619); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setError10620; 
		protected virtual void setError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _setError10620); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _setError10620); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearError10621; 
		protected virtual void clearError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				@__env.CallVoidMethod(this, _clearError10621); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.PrintWriter.staticClass, _clearError10621); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _printf10622; 
		public virtual java.io.PrintWriter printf(java.lang.String arg0, java.lang.Object[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, _printf10622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.PrintWriter.staticClass, _printf10622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _printf10623; 
		public virtual java.io.PrintWriter printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.PrintWriter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, _printf10623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.io.PrintWriter.staticClass, _printf10623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter10624; 
		public PrintWriter(java.io.Writer arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.PrintWriter.staticClass, _PrintWriter10624, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter10625; 
		public PrintWriter(java.io.OutputStream arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.PrintWriter.staticClass, _PrintWriter10625, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter10626; 
		public PrintWriter(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.PrintWriter.staticClass, _PrintWriter10626, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter10627; 
		public PrintWriter(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.PrintWriter.staticClass, _PrintWriter10627, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter10628; 
		public PrintWriter(java.io.File arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.PrintWriter.staticClass, _PrintWriter10628, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter10629; 
		public PrintWriter(java.io.File arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.PrintWriter.staticClass, _PrintWriter10629, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter10630; 
		public PrintWriter(java.io.Writer arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.PrintWriter.staticClass, _PrintWriter10630, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter10631; 
		public PrintWriter(java.io.OutputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.PrintWriter.staticClass, _PrintWriter10631, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.io.PrintWriter.staticClass = @__class; 
			global::java.io.PrintWriter._println10588 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(C)V"); 
			global::java.io.PrintWriter._println10589 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "()V"); 
			global::java.io.PrintWriter._println10590 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(Z)V"); 
			global::java.io.PrintWriter._println10591 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/Object;)V"); 
			global::java.io.PrintWriter._println10592 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/String;)V"); 
			global::java.io.PrintWriter._println10593 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "([C)V"); 
			global::java.io.PrintWriter._println10594 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(D)V"); 
			global::java.io.PrintWriter._println10595 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(F)V"); 
			global::java.io.PrintWriter._println10596 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(J)V"); 
			global::java.io.PrintWriter._println10597 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(I)V"); 
			global::java.io.PrintWriter._append10598 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;"); 
			global::java.io.PrintWriter._append10599 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;"); 
			global::java.io.PrintWriter._append10600 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "append", "(C)Ljava/io/PrintWriter;"); 
			global::java.io.PrintWriter._format10601 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;"); 
			global::java.io.PrintWriter._format10602 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;"); 
			global::java.io.PrintWriter._write10603 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "([C)V"); 
			global::java.io.PrintWriter._write10604 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "([CII)V"); 
			global::java.io.PrintWriter._write10605 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "(I)V"); 
			global::java.io.PrintWriter._write10606 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;II)V"); 
			global::java.io.PrintWriter._write10607 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;)V"); 
			global::java.io.PrintWriter._print10608 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/String;)V"); 
			global::java.io.PrintWriter._print10609 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/Object;)V"); 
			global::java.io.PrintWriter._print10610 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(Z)V"); 
			global::java.io.PrintWriter._print10611 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(C)V"); 
			global::java.io.PrintWriter._print10612 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(I)V"); 
			global::java.io.PrintWriter._print10613 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(J)V"); 
			global::java.io.PrintWriter._print10614 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(F)V"); 
			global::java.io.PrintWriter._print10615 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(D)V"); 
			global::java.io.PrintWriter._print10616 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "([C)V"); 
			global::java.io.PrintWriter._flush10617 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "flush", "()V"); 
			global::java.io.PrintWriter._close10618 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "close", "()V"); 
			global::java.io.PrintWriter._checkError10619 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "checkError", "()Z"); 
			global::java.io.PrintWriter._setError10620 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "setError", "()V"); 
			global::java.io.PrintWriter._clearError10621 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "clearError", "()V"); 
			global::java.io.PrintWriter._printf10622 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;"); 
			global::java.io.PrintWriter._printf10623 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;"); 
			global::java.io.PrintWriter._PrintWriter10624 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;Z)V"); 
			global::java.io.PrintWriter._PrintWriter10625 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V"); 
			global::java.io.PrintWriter._PrintWriter10626 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::java.io.PrintWriter._PrintWriter10627 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.io.PrintWriter._PrintWriter10628 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;)V"); 
			global::java.io.PrintWriter._PrintWriter10629 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V"); 
			global::java.io.PrintWriter._PrintWriter10630 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;)V"); 
			global::java.io.PrintWriter._PrintWriter10631 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V"); 
		} 
	} 
} 
