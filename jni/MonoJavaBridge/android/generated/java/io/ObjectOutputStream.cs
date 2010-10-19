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
			internal static global::MonoJavaBridge.MethodId _put13651;
			public abstract void put(java.lang.String arg0, bool arg1);
			internal static global::MonoJavaBridge.MethodId _put13652;
			public abstract void put(java.lang.String arg0, byte arg1);
			internal static global::MonoJavaBridge.MethodId _put13653;
			public abstract void put(java.lang.String arg0, char arg1);
			internal static global::MonoJavaBridge.MethodId _put13654;
			public abstract void put(java.lang.String arg0, short arg1);
			internal static global::MonoJavaBridge.MethodId _put13655;
			public abstract void put(java.lang.String arg0, long arg1);
			internal static global::MonoJavaBridge.MethodId _put13656;
			public abstract void put(java.lang.String arg0, float arg1);
			internal static global::MonoJavaBridge.MethodId _put13657;
			public abstract void put(java.lang.String arg0, double arg1);
			internal static global::MonoJavaBridge.MethodId _put13658;
			public abstract void put(java.lang.String arg0, java.lang.Object arg1);
			internal static global::MonoJavaBridge.MethodId _put13659;
			public abstract void put(java.lang.String arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _write13660;
			public abstract void write(java.io.ObjectOutput arg0);
			internal static global::MonoJavaBridge.MethodId _PutField13661;
			public PutField()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.PutField.staticClass, global::java.io.ObjectOutputStream.PutField._PutField13661);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectOutputStream.PutField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream$PutField"));
				global::java.io.ObjectOutputStream.PutField._put13651 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;Z)V");
				global::java.io.ObjectOutputStream.PutField._put13652 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;B)V");
				global::java.io.ObjectOutputStream.PutField._put13653 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;C)V");
				global::java.io.ObjectOutputStream.PutField._put13654 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;S)V");
				global::java.io.ObjectOutputStream.PutField._put13655 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;J)V");
				global::java.io.ObjectOutputStream.PutField._put13656 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;F)V");
				global::java.io.ObjectOutputStream.PutField._put13657 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;D)V");
				global::java.io.ObjectOutputStream.PutField._put13658 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)V");
				global::java.io.ObjectOutputStream.PutField._put13659 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "put", "(Ljava/lang/String;I)V");
				global::java.io.ObjectOutputStream.PutField._write13660 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "write", "(Ljava/io/ObjectOutput;)V");
				global::java.io.ObjectOutputStream.PutField._PutField13661 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _put13662;
			public override void put(java.lang.String arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put13662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put13662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put13663;
			public override void put(java.lang.String arg0, byte arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put13663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put13663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put13664;
			public override void put(java.lang.String arg0, char arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put13664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put13664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put13665;
			public override void put(java.lang.String arg0, short arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put13665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put13665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put13666;
			public override void put(java.lang.String arg0, long arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put13666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put13666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put13667;
			public override void put(java.lang.String arg0, float arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put13667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put13667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put13668;
			public override void put(java.lang.String arg0, double arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put13668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put13668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put13669;
			public override void put(java.lang.String arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put13669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put13669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _put13670;
			public override void put(java.lang.String arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._put13670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._put13670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _write13671;
			public override void write(java.io.ObjectOutput arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_._write13671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.PutField_.staticClass, global::java.io.ObjectOutputStream.PutField_._write13671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectOutputStream.PutField_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream$PutField"));
				global::java.io.ObjectOutputStream.PutField_._put13662 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;Z)V");
				global::java.io.ObjectOutputStream.PutField_._put13663 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;B)V");
				global::java.io.ObjectOutputStream.PutField_._put13664 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;C)V");
				global::java.io.ObjectOutputStream.PutField_._put13665 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;S)V");
				global::java.io.ObjectOutputStream.PutField_._put13666 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;J)V");
				global::java.io.ObjectOutputStream.PutField_._put13667 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;F)V");
				global::java.io.ObjectOutputStream.PutField_._put13668 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;D)V");
				global::java.io.ObjectOutputStream.PutField_._put13669 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)V");
				global::java.io.ObjectOutputStream.PutField_._put13670 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;I)V");
				global::java.io.ObjectOutputStream.PutField_._write13671 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField_.staticClass, "write", "(Ljava/io/ObjectOutput;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _write13672;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._write13672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._write13672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write13673;
		public override void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._write13673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._write13673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13674;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._write13674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._write13674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeObject13675;
		public virtual void writeObject(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeObject13675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeObject13675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _defaultWriteObject13676;
		public virtual void defaultWriteObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._defaultWriteObject13676);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._defaultWriteObject13676);
		}
		internal static global::MonoJavaBridge.MethodId _flush13677;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._flush13677);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._flush13677);
		}
		internal static global::MonoJavaBridge.MethodId _close13678;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._close13678);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._close13678);
		}
		internal static global::MonoJavaBridge.MethodId _writeInt13679;
		public virtual void writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeInt13679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeInt13679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFields13680;
		public virtual global::java.io.ObjectOutputStream.PutField putFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectOutputStream._putFields13680)) as java.io.ObjectOutputStream.PutField;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._putFields13680)) as java.io.ObjectOutputStream.PutField;
		}
		internal static global::MonoJavaBridge.MethodId _writeFields13681;
		public virtual void writeFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeFields13681);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeFields13681);
		}
		internal static global::MonoJavaBridge.MethodId _reset13682;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._reset13682);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._reset13682);
		}
		internal static global::MonoJavaBridge.MethodId _writeChar13683;
		public virtual void writeChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeChar13683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeChar13683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes13684;
		public virtual void writeBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeBytes13684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeBytes13684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF13685;
		public virtual void writeUTF(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeUTF13685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeUTF13685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong13686;
		public virtual void writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeLong13686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeLong13686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte13687;
		public virtual void writeByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeByte13687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeByte13687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort13688;
		public virtual void writeShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeShort13688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeShort13688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat13689;
		public virtual void writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeFloat13689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeFloat13689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble13690;
		public virtual void writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeDouble13690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeDouble13690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _useProtocolVersion13691;
		public virtual void useProtocolVersion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._useProtocolVersion13691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._useProtocolVersion13691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeObjectOverride13692;
		protected virtual void writeObjectOverride(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeObjectOverride13692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeObjectOverride13692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUnshared13693;
		public virtual void writeUnshared(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeUnshared13693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeUnshared13693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _annotateClass13694;
		protected virtual void annotateClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._annotateClass13694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._annotateClass13694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _annotateProxyClass13695;
		protected virtual void annotateProxyClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._annotateProxyClass13695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._annotateProxyClass13695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _replaceObject13696;
		protected virtual global::java.lang.Object replaceObject(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectOutputStream._replaceObject13696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._replaceObject13696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _enableReplaceObject13697;
		protected virtual bool enableReplaceObject(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectOutputStream._enableReplaceObject13697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._enableReplaceObject13697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStreamHeader13698;
		protected virtual void writeStreamHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeStreamHeader13698);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeStreamHeader13698);
		}
		internal static global::MonoJavaBridge.MethodId _writeClassDescriptor13699;
		protected virtual void writeClassDescriptor(java.io.ObjectStreamClass arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeClassDescriptor13699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeClassDescriptor13699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drain13700;
		protected virtual void drain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._drain13700);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._drain13700);
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean13701;
		public virtual void writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeBoolean13701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeBoolean13701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars13702;
		public virtual void writeChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream._writeChars13702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._writeChars13702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ObjectOutputStream13703;
		public ObjectOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._ObjectOutputStream13703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectOutputStream13704;
		protected ObjectOutputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._ObjectOutputStream13704);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream"));
			global::java.io.ObjectOutputStream._write13672 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "write", "([BII)V");
			global::java.io.ObjectOutputStream._write13673 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "write", "([B)V");
			global::java.io.ObjectOutputStream._write13674 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "write", "(I)V");
			global::java.io.ObjectOutputStream._writeObject13675 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeObject", "(Ljava/lang/Object;)V");
			global::java.io.ObjectOutputStream._defaultWriteObject13676 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "defaultWriteObject", "()V");
			global::java.io.ObjectOutputStream._flush13677 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "flush", "()V");
			global::java.io.ObjectOutputStream._close13678 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "close", "()V");
			global::java.io.ObjectOutputStream._writeInt13679 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeInt", "(I)V");
			global::java.io.ObjectOutputStream._putFields13680 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "putFields", "()Ljava/io/ObjectOutputStream$PutField;");
			global::java.io.ObjectOutputStream._writeFields13681 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeFields", "()V");
			global::java.io.ObjectOutputStream._reset13682 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "reset", "()V");
			global::java.io.ObjectOutputStream._writeChar13683 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeChar", "(I)V");
			global::java.io.ObjectOutputStream._writeBytes13684 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			global::java.io.ObjectOutputStream._writeUTF13685 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			global::java.io.ObjectOutputStream._writeLong13686 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeLong", "(J)V");
			global::java.io.ObjectOutputStream._writeByte13687 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeByte", "(I)V");
			global::java.io.ObjectOutputStream._writeShort13688 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeShort", "(I)V");
			global::java.io.ObjectOutputStream._writeFloat13689 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeFloat", "(F)V");
			global::java.io.ObjectOutputStream._writeDouble13690 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeDouble", "(D)V");
			global::java.io.ObjectOutputStream._useProtocolVersion13691 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "useProtocolVersion", "(I)V");
			global::java.io.ObjectOutputStream._writeObjectOverride13692 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeObjectOverride", "(Ljava/lang/Object;)V");
			global::java.io.ObjectOutputStream._writeUnshared13693 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeUnshared", "(Ljava/lang/Object;)V");
			global::java.io.ObjectOutputStream._annotateClass13694 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "annotateClass", "(Ljava/lang/Class;)V");
			global::java.io.ObjectOutputStream._annotateProxyClass13695 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "annotateProxyClass", "(Ljava/lang/Class;)V");
			global::java.io.ObjectOutputStream._replaceObject13696 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "replaceObject", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.io.ObjectOutputStream._enableReplaceObject13697 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "enableReplaceObject", "(Z)Z");
			global::java.io.ObjectOutputStream._writeStreamHeader13698 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeStreamHeader", "()V");
			global::java.io.ObjectOutputStream._writeClassDescriptor13699 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeClassDescriptor", "(Ljava/io/ObjectStreamClass;)V");
			global::java.io.ObjectOutputStream._drain13700 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "drain", "()V");
			global::java.io.ObjectOutputStream._writeBoolean13701 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeBoolean", "(Z)V");
			global::java.io.ObjectOutputStream._writeChars13702 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "writeChars", "(Ljava/lang/String;)V");
			global::java.io.ObjectOutputStream._ObjectOutputStream13703 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::java.io.ObjectOutputStream._ObjectOutputStream13704 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "<init>", "()V");
		}
	}
}
