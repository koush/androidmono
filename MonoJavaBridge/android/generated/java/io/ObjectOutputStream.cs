namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ObjectOutputStream : java.io.OutputStream, ObjectOutput, ObjectStreamConstants
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ObjectOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.io.ObjectOutputStream.PutField_))]
		public abstract partial class PutField : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PutField(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public abstract void put(java.lang.String arg0, bool arg1);
			private static global::MonoJavaBridge.MethodId _m1;
			public abstract void put(java.lang.String arg0, byte arg1);
			private static global::MonoJavaBridge.MethodId _m2;
			public abstract void put(java.lang.String arg0, char arg1);
			private static global::MonoJavaBridge.MethodId _m3;
			public abstract void put(java.lang.String arg0, short arg1);
			private static global::MonoJavaBridge.MethodId _m4;
			public abstract void put(java.lang.String arg0, long arg1);
			private static global::MonoJavaBridge.MethodId _m5;
			public abstract void put(java.lang.String arg0, float arg1);
			private static global::MonoJavaBridge.MethodId _m6;
			public abstract void put(java.lang.String arg0, double arg1);
			private static global::MonoJavaBridge.MethodId _m7;
			public abstract void put(java.lang.String arg0, java.lang.Object arg1);
			private static global::MonoJavaBridge.MethodId _m8;
			public abstract void put(java.lang.String arg0, int arg1);
			private static global::MonoJavaBridge.MethodId _m9;
			public abstract void write(java.io.ObjectOutput arg0);
			private static global::MonoJavaBridge.MethodId _m10;
			public PutField() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.io.ObjectOutputStream.PutField._m10.native == global::System.IntPtr.Zero)
					global::java.io.ObjectOutputStream.PutField._m10 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.PutField.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.PutField.staticClass, global::java.io.ObjectOutputStream.PutField._m10);
				Init(@__env, handle);
			}
			static PutField()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectOutputStream.PutField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream$PutField"));
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectOutputStream.PutField))]
		internal sealed partial class PutField_ : java.io.ObjectOutputStream.PutField
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PutField_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override void put(java.lang.String arg0, bool arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;Z)V", ref global::java.io.ObjectOutputStream.PutField_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override void put(java.lang.String arg0, byte arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;B)V", ref global::java.io.ObjectOutputStream.PutField_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override void put(java.lang.String arg0, char arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;C)V", ref global::java.io.ObjectOutputStream.PutField_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public override void put(java.lang.String arg0, short arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;S)V", ref global::java.io.ObjectOutputStream.PutField_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public override void put(java.lang.String arg0, long arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;J)V", ref global::java.io.ObjectOutputStream.PutField_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public override void put(java.lang.String arg0, float arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;F)V", ref global::java.io.ObjectOutputStream.PutField_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public override void put(java.lang.String arg0, double arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;D)V", ref global::java.io.ObjectOutputStream.PutField_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public override void put(java.lang.String arg0, java.lang.Object arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.io.ObjectOutputStream.PutField_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public override void put(java.lang.String arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "put", "(Ljava/lang/String;I)V", ref global::java.io.ObjectOutputStream.PutField_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public override void write(java.io.ObjectOutput arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.PutField_.staticClass, "write", "(Ljava/io/ObjectOutput;)V", ref global::java.io.ObjectOutputStream.PutField_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static PutField_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectOutputStream.PutField_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream$PutField"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "write", "([BII)V", ref global::java.io.ObjectOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "write", "([B)V", ref global::java.io.ObjectOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "write", "(I)V", ref global::java.io.ObjectOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void writeObject(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeObject", "(Ljava/lang/Object;)V", ref global::java.io.ObjectOutputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void defaultWriteObject()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "defaultWriteObject", "()V", ref global::java.io.ObjectOutputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "flush", "()V", ref global::java.io.ObjectOutputStream._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "close", "()V", ref global::java.io.ObjectOutputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeInt", "(I)V", ref global::java.io.ObjectOutputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.io.ObjectOutputStream.PutField putFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectOutputStream.staticClass, "putFields", "()Ljava/io/ObjectOutputStream$PutField;", ref global::java.io.ObjectOutputStream._m8) as java.io.ObjectOutputStream.PutField;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void writeFields()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeFields", "()V", ref global::java.io.ObjectOutputStream._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "reset", "()V", ref global::java.io.ObjectOutputStream._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void writeChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeChar", "(I)V", ref global::java.io.ObjectOutputStream._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void writeBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeBytes", "(Ljava/lang/String;)V", ref global::java.io.ObjectOutputStream._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void writeUTF(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeUTF", "(Ljava/lang/String;)V", ref global::java.io.ObjectOutputStream._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeLong", "(J)V", ref global::java.io.ObjectOutputStream._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void writeByte(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeByte", "(I)V", ref global::java.io.ObjectOutputStream._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void writeShort(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeShort", "(I)V", ref global::java.io.ObjectOutputStream._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeFloat", "(F)V", ref global::java.io.ObjectOutputStream._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeDouble", "(D)V", ref global::java.io.ObjectOutputStream._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void useProtocolVersion(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "useProtocolVersion", "(I)V", ref global::java.io.ObjectOutputStream._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		protected virtual void writeObjectOverride(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeObjectOverride", "(Ljava/lang/Object;)V", ref global::java.io.ObjectOutputStream._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void writeUnshared(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeUnshared", "(Ljava/lang/Object;)V", ref global::java.io.ObjectOutputStream._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected virtual void annotateClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "annotateClass", "(Ljava/lang/Class;)V", ref global::java.io.ObjectOutputStream._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected virtual void annotateProxyClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "annotateProxyClass", "(Ljava/lang/Class;)V", ref global::java.io.ObjectOutputStream._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		protected virtual global::java.lang.Object replaceObject(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectOutputStream.staticClass, "replaceObject", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.io.ObjectOutputStream._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		protected virtual bool enableReplaceObject(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectOutputStream.staticClass, "enableReplaceObject", "(Z)Z", ref global::java.io.ObjectOutputStream._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected virtual void writeStreamHeader()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeStreamHeader", "()V", ref global::java.io.ObjectOutputStream._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected virtual void writeClassDescriptor(java.io.ObjectStreamClass arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeClassDescriptor", "(Ljava/io/ObjectStreamClass;)V", ref global::java.io.ObjectOutputStream._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		protected virtual void drain()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "drain", "()V", ref global::java.io.ObjectOutputStream._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeBoolean", "(Z)V", ref global::java.io.ObjectOutputStream._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void writeChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutputStream.staticClass, "writeChars", "(Ljava/lang/String;)V", ref global::java.io.ObjectOutputStream._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public ObjectOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutputStream._m31.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutputStream._m31 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		protected ObjectOutputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutputStream._m32.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutputStream._m32 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectOutputStream.staticClass, global::java.io.ObjectOutputStream._m32);
			Init(@__env, handle);
		}
		static ObjectOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutputStream"));
		}
	}
}
