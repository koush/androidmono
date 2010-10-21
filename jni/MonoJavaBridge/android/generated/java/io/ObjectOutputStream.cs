namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ObjectOutputStream : java.io.OutputStream, ObjectOutput, ObjectStreamConstants
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ObjectOutputStream()
		{
			InitJNI();
		}
		protected ObjectOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.io.ObjectOutputStream.PutField_))]
		public abstract partial class PutField : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PutField()
			{
				InitJNI();
			}
			protected PutField(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _put19126;
			public abstract void put(java.lang.String arg0, bool arg1);
			internal static global::MonoJavaBridge.MethodId _put19127;
			public abstract void put(java.lang.String arg0, byte arg1);
			internal static global::MonoJavaBridge.MethodId _put19128;
			public abstract void put(java.lang.String arg0, char arg1);
			internal static global::MonoJavaBridge.MethodId _put19129;
			public abstract void put(java.lang.String arg0, short arg1);
			internal static global::MonoJavaBridge.MethodId _put19130;
			public abstract void put(java.lang.String arg0, long arg1);
			internal static global::MonoJavaBridge.MethodId _put19131;
			public abstract void put(java.lang.String arg0, float arg1);
			internal static global::MonoJavaBridge.MethodId _put19132;
			public abstract void put(java.lang.String arg0, double arg1);
			internal static global::MonoJavaBridge.MethodId _put19133;
			public abstract void put(java.lang.String arg0, java.lang.Object arg1);
			internal static global::MonoJavaBridge.MethodId _put19134;
			public abstract void put(java.lang.String arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _write19135;
			public abstract void write(java.io.ObjectOutput arg0);
			internal static global::MonoJavaBridge.MethodId _PutField19136;
			public PutField()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.PutField.staticClass, global::java.io.ObjectOutputStream.PutField._PutField19136);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectOutputStream.PutField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream$PutField"));
				global::java.io.ObjectOutputStream.PutField._put19126 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;Z)V");
				global::java.io.ObjectOutputStream.PutField._put19127 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;B)V");
				global::java.io.ObjectOutputStream.PutField._put19128 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;C)V");
				global::java.io.ObjectOutputStream.PutField._put19129 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;S)V");
				global::java.io.ObjectOutputStream.PutField._put19130 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;J)V");
				global::java.io.ObjectOutputStream.PutField._put19131 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;F)V");
				global::java.io.ObjectOutputStream.PutField._put19132 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;D)V");
				global::java.io.ObjectOutputStream.PutField._put19133 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)V");
				global::java.io.ObjectOutputStream.PutField._put19134 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;I)V");
				global::java.io.ObjectOutputStream.PutField._write19135 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "write", "(Ljava/io/ObjectOutput;)V");
				global::java.io.ObjectOutputStream.PutField._PutField19136 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "<init>", "()V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectOutputStream.PutField))]
		public sealed partial class PutField_ : java.io.ObjectOutputStream.PutField
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PutField_()
			{
				InitJNI();
			}
			internal PutField_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _put19137;
			public override void put(java.lang.String arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put19137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put19137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19138;
			public override void put(java.lang.String arg0, byte arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put19138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put19138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19139;
			public override void put(java.lang.String arg0, char arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put19139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put19139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19140;
			public override void put(java.lang.String arg0, short arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put19140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put19140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19141;
			public override void put(java.lang.String arg0, long arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put19141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put19141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19142;
			public override void put(java.lang.String arg0, float arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put19142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put19142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19143;
			public override void put(java.lang.String arg0, double arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put19143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put19143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19144;
			public override void put(java.lang.String arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put19144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put19144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put19145;
			public override void put(java.lang.String arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put19145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put19145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _write19146;
			public override void write(java.io.ObjectOutput arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._write19146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._write19146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectOutputStream.PutField_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream$PutField"));
				global::java.io.ObjectOutputStream.PutField_._put19137 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;Z)V");
				global::java.io.ObjectOutputStream.PutField_._put19138 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;B)V");
				global::java.io.ObjectOutputStream.PutField_._put19139 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;C)V");
				global::java.io.ObjectOutputStream.PutField_._put19140 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;S)V");
				global::java.io.ObjectOutputStream.PutField_._put19141 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;J)V");
				global::java.io.ObjectOutputStream.PutField_._put19142 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;F)V");
				global::java.io.ObjectOutputStream.PutField_._put19143 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;D)V");
				global::java.io.ObjectOutputStream.PutField_._put19144 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)V");
				global::java.io.ObjectOutputStream.PutField_._put19145 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;I)V");
				global::java.io.ObjectOutputStream.PutField_._write19146 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "write", "(Ljava/io/ObjectOutput;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _write19147;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._write19147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._write19147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19148;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._write19148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._write19148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19149;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._write19149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._write19149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeObject19150;
		public virtual void writeObject(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeObject19150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeObject19150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _defaultWriteObject19151;
		public virtual void defaultWriteObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._defaultWriteObject19151);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._defaultWriteObject19151);
		}
		internal static global::MonoJavaBridge.MethodId _flush19152;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._flush19152);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._flush19152);
		}
		internal static global::MonoJavaBridge.MethodId _close19153;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._close19153);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._close19153);
		}
		internal static global::MonoJavaBridge.MethodId _writeInt19154;
		public virtual void writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeInt19154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeInt19154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFields19155;
		public virtual global::java.io.ObjectOutputStream.PutField putFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectOutputStream._putFields19155)) as java.io.ObjectOutputStream.PutField;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._putFields19155)) as java.io.ObjectOutputStream.PutField;
		}
		internal static global::MonoJavaBridge.MethodId _writeFields19156;
		public virtual void writeFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeFields19156);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeFields19156);
		}
		internal static global::MonoJavaBridge.MethodId _reset19157;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._reset19157);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._reset19157);
		}
		internal static global::MonoJavaBridge.MethodId _writeChar19158;
		public virtual void writeChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeChar19158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeChar19158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes19159;
		public virtual void writeBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeBytes19159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeBytes19159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF19160;
		public virtual void writeUTF(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeUTF19160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeUTF19160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong19161;
		public virtual void writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeLong19161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeLong19161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte19162;
		public virtual void writeByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeByte19162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeByte19162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort19163;
		public virtual void writeShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeShort19163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeShort19163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat19164;
		public virtual void writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeFloat19164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeFloat19164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble19165;
		public virtual void writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeDouble19165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeDouble19165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _useProtocolVersion19166;
		public virtual void useProtocolVersion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._useProtocolVersion19166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._useProtocolVersion19166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeObjectOverride19167;
		protected virtual void writeObjectOverride(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeObjectOverride19167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeObjectOverride19167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUnshared19168;
		public virtual void writeUnshared(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeUnshared19168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeUnshared19168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _annotateClass19169;
		protected virtual void annotateClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._annotateClass19169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._annotateClass19169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _annotateProxyClass19170;
		protected virtual void annotateProxyClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._annotateProxyClass19170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._annotateProxyClass19170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _replaceObject19171;
		protected virtual global::java.lang.Object replaceObject(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectOutputStream._replaceObject19171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._replaceObject19171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _enableReplaceObject19172;
		protected virtual bool enableReplaceObject(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectOutputStream._enableReplaceObject19172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._enableReplaceObject19172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStreamHeader19173;
		protected virtual void writeStreamHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeStreamHeader19173);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeStreamHeader19173);
		}
		internal static global::MonoJavaBridge.MethodId _writeClassDescriptor19174;
		protected virtual void writeClassDescriptor(java.io.ObjectStreamClass arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeClassDescriptor19174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeClassDescriptor19174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drain19175;
		protected virtual void drain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._drain19175);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._drain19175);
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean19176;
		public virtual void writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeBoolean19176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeBoolean19176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars19177;
		public virtual void writeChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeChars19177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeChars19177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ObjectOutputStream19178;
		public ObjectOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._ObjectOutputStream19178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectOutputStream19179;
		protected ObjectOutputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._ObjectOutputStream19179);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream"));
			global::java.io.ObjectOutputStream._write19147 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "write", "([BII)V");
			global::java.io.ObjectOutputStream._write19148 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "write", "([B)V");
			global::java.io.ObjectOutputStream._write19149 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "write", "(I)V");
			global::java.io.ObjectOutputStream._writeObject19150 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeObject", "(Ljava/lang/Object;)V");
			global::java.io.ObjectOutputStream._defaultWriteObject19151 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "defaultWriteObject", "()V");
			global::java.io.ObjectOutputStream._flush19152 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "flush", "()V");
			global::java.io.ObjectOutputStream._close19153 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "close", "()V");
			global::java.io.ObjectOutputStream._writeInt19154 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeInt", "(I)V");
			global::java.io.ObjectOutputStream._putFields19155 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "putFields", "()Ljava/io/ObjectOutputStream$PutField;");
			global::java.io.ObjectOutputStream._writeFields19156 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeFields", "()V");
			global::java.io.ObjectOutputStream._reset19157 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "reset", "()V");
			global::java.io.ObjectOutputStream._writeChar19158 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeChar", "(I)V");
			global::java.io.ObjectOutputStream._writeBytes19159 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			global::java.io.ObjectOutputStream._writeUTF19160 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			global::java.io.ObjectOutputStream._writeLong19161 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeLong", "(J)V");
			global::java.io.ObjectOutputStream._writeByte19162 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeByte", "(I)V");
			global::java.io.ObjectOutputStream._writeShort19163 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeShort", "(I)V");
			global::java.io.ObjectOutputStream._writeFloat19164 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeFloat", "(F)V");
			global::java.io.ObjectOutputStream._writeDouble19165 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeDouble", "(D)V");
			global::java.io.ObjectOutputStream._useProtocolVersion19166 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "useProtocolVersion", "(I)V");
			global::java.io.ObjectOutputStream._writeObjectOverride19167 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeObjectOverride", "(Ljava/lang/Object;)V");
			global::java.io.ObjectOutputStream._writeUnshared19168 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeUnshared", "(Ljava/lang/Object;)V");
			global::java.io.ObjectOutputStream._annotateClass19169 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "annotateClass", "(Ljava/lang/Class;)V");
			global::java.io.ObjectOutputStream._annotateProxyClass19170 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "annotateProxyClass", "(Ljava/lang/Class;)V");
			global::java.io.ObjectOutputStream._replaceObject19171 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "replaceObject", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.io.ObjectOutputStream._enableReplaceObject19172 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "enableReplaceObject", "(Z)Z");
			global::java.io.ObjectOutputStream._writeStreamHeader19173 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeStreamHeader", "()V");
			global::java.io.ObjectOutputStream._writeClassDescriptor19174 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeClassDescriptor", "(Ljava/io/ObjectStreamClass;)V");
			global::java.io.ObjectOutputStream._drain19175 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "drain", "()V");
			global::java.io.ObjectOutputStream._writeBoolean19176 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeBoolean", "(Z)V");
			global::java.io.ObjectOutputStream._writeChars19177 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeChars", "(Ljava/lang/String;)V");
			global::java.io.ObjectOutputStream._ObjectOutputStream19178 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::java.io.ObjectOutputStream._ObjectOutputStream19179 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "<init>", "()V");
		}
	}
}
