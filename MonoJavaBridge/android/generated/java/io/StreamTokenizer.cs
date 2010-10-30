namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamTokenizer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StreamTokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19577;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._toString19577.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._toString19577 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._toString19577) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextToken19578;
		public virtual int nextToken()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._nextToken19578.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._nextToken19578 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "nextToken", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._nextToken19578);
		}
		internal static global::MonoJavaBridge.MethodId _pushBack19579;
		public virtual void pushBack()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._pushBack19579.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._pushBack19579 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "pushBack", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._pushBack19579);
		}
		internal static global::MonoJavaBridge.MethodId _resetSyntax19580;
		public virtual void resetSyntax()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._resetSyntax19580.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._resetSyntax19580 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "resetSyntax", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._resetSyntax19580);
		}
		internal static global::MonoJavaBridge.MethodId _wordChars19581;
		public virtual void wordChars(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._wordChars19581.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._wordChars19581 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "wordChars", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._wordChars19581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _whitespaceChars19582;
		public virtual void whitespaceChars(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._whitespaceChars19582.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._whitespaceChars19582 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "whitespaceChars", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._whitespaceChars19582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ordinaryChars19583;
		public virtual void ordinaryChars(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._ordinaryChars19583.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._ordinaryChars19583 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "ordinaryChars", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._ordinaryChars19583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ordinaryChar19584;
		public virtual void ordinaryChar(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._ordinaryChar19584.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._ordinaryChar19584 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "ordinaryChar", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._ordinaryChar19584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _commentChar19585;
		public virtual void commentChar(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._commentChar19585.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._commentChar19585 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "commentChar", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._commentChar19585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quoteChar19586;
		public virtual void quoteChar(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._quoteChar19586.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._quoteChar19586 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "quoteChar", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._quoteChar19586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseNumbers19587;
		public virtual void parseNumbers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._parseNumbers19587.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._parseNumbers19587 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "parseNumbers", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._parseNumbers19587);
		}
		internal static global::MonoJavaBridge.MethodId _eolIsSignificant19588;
		public virtual void eolIsSignificant(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._eolIsSignificant19588.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._eolIsSignificant19588 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "eolIsSignificant", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._eolIsSignificant19588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _slashStarComments19589;
		public virtual void slashStarComments(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._slashStarComments19589.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._slashStarComments19589 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "slashStarComments", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._slashStarComments19589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _slashSlashComments19590;
		public virtual void slashSlashComments(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._slashSlashComments19590.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._slashSlashComments19590 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "slashSlashComments", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._slashSlashComments19590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowerCaseMode19591;
		public virtual void lowerCaseMode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._lowerCaseMode19591.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._lowerCaseMode19591 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "lowerCaseMode", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._lowerCaseMode19591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lineno19592;
		public virtual int lineno()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._lineno19592.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._lineno19592 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "lineno", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._lineno19592);
		}
		internal static global::MonoJavaBridge.MethodId _StreamTokenizer19593;
		public StreamTokenizer(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._StreamTokenizer19593.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._StreamTokenizer19593 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._StreamTokenizer19593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamTokenizer19594;
		public StreamTokenizer(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StreamTokenizer._StreamTokenizer19594.native == global::System.IntPtr.Zero)
				global::java.io.StreamTokenizer._StreamTokenizer19594 = @__env.GetMethodIDNoThrow(global::java.io.StreamTokenizer.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamTokenizer.staticClass, global::java.io.StreamTokenizer._StreamTokenizer19594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ttype19595;
		public int ttype
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ttype19595);
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
		internal static global::MonoJavaBridge.FieldId _sval19600;
		public global::java.lang.String sval
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sval19600)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nval19601;
		public double nval
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetDoubleField(this.JvmHandle, _nval19601);
			}
			set
			{
			}
		}
		static StreamTokenizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StreamTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StreamTokenizer"));
			global::java.io.StreamTokenizer._ttype19595 = @__env.GetFieldIDNoThrow(global::java.io.StreamTokenizer.staticClass, "ttype", "I");
			global::java.io.StreamTokenizer._sval19600 = @__env.GetFieldIDNoThrow(global::java.io.StreamTokenizer.staticClass, "sval", "Ljava/lang/String;");
			global::java.io.StreamTokenizer._nval19601 = @__env.GetFieldIDNoThrow(global::java.io.StreamTokenizer.staticClass, "nval", "D");
		}
		internal static void InitJNI()
		{
		}
	}
}
