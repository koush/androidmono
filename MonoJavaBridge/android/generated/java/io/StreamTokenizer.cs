namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamTokenizer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StreamTokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.StreamTokenizer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.io.StreamTokenizer._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StreamTokenizer.staticClass, "nextToken", "()I", ref global::java.io.StreamTokenizer._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void pushBack()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "pushBack", "()V", ref global::java.io.StreamTokenizer._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void resetSyntax()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "resetSyntax", "()V", ref global::java.io.StreamTokenizer._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void wordChars(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "wordChars", "(II)V", ref global::java.io.StreamTokenizer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void whitespaceChars(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "whitespaceChars", "(II)V", ref global::java.io.StreamTokenizer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void ordinaryChars(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "ordinaryChars", "(II)V", ref global::java.io.StreamTokenizer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void ordinaryChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "ordinaryChar", "(I)V", ref global::java.io.StreamTokenizer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void commentChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "commentChar", "(I)V", ref global::java.io.StreamTokenizer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void quoteChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "quoteChar", "(I)V", ref global::java.io.StreamTokenizer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void parseNumbers()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "parseNumbers", "()V", ref global::java.io.StreamTokenizer._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void eolIsSignificant(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "eolIsSignificant", "(Z)V", ref global::java.io.StreamTokenizer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void slashStarComments(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "slashStarComments", "(Z)V", ref global::java.io.StreamTokenizer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void slashSlashComments(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "slashSlashComments", "(Z)V", ref global::java.io.StreamTokenizer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void lowerCaseMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, "lowerCaseMode", "(Z)V", ref global::java.io.StreamTokenizer._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int lineno()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StreamTokenizer.staticClass, "lineno", "()I", ref global::java.io.StreamTokenizer._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public StreamTokenizer(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._m16.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._m16 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public StreamTokenizer(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._m17.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._m17 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ttype6233;
		public int ttype
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ttype6233);
			}
			set
			{
			}
		}
		public static int TT_EOF
		{
			get
			{
				return -1;
			}
		}
		public static int TT_EOL
		{
			get
			{
				return 10;
			}
		}
		public static int TT_NUMBER
		{
			get
			{
				return -2;
			}
		}
		public static int TT_WORD
		{
			get
			{
				return -3;
			}
		}
		internal static global::MonoJavaBridge.FieldId _sval6238;
		public global::java.lang.String sval
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sval6238)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nval6239;
		public double nval
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetDoubleField(this.JvmHandle, _nval6239);
			}
			set
			{
			}
		}
		static StreamTokenizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StreamTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StreamTokenizer"));
			global::java.io.StreamTokenizer._ttype6233 = @__env.GetFieldIDNoThrow(global::java.io.StreamTokenizer.staticClass, "ttype", "I");
			global::java.io.StreamTokenizer._sval6238 = @__env.GetFieldIDNoThrow(global::java.io.StreamTokenizer.staticClass, "sval", "Ljava/lang/String;");
			global::java.io.StreamTokenizer._nval6239 = @__env.GetFieldIDNoThrow(global::java.io.StreamTokenizer.staticClass, "nval", "D");
		}
	}
}
