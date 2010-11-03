namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipEntry : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZipEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.zip.ZipEntry.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.zip.ZipEntry._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.ZipEntry.staticClass, "hashCode", "()I", ref global::java.util.zip.ZipEntry._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.zip.ZipEntry.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.zip.ZipEntry._m2) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.zip.ZipEntry.staticClass, "getName", "()Ljava/lang/String;", ref global::java.util.zip.ZipEntry._m3) as java.lang.String;
		}
		public new int Method
		{
			get
			{
				return getMethod();
			}
			set
			{
				setMethod(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.ZipEntry.staticClass, "getMethod", "()I", ref global::java.util.zip.ZipEntry._m4);
		}
		public new long Size
		{
			get
			{
				return getSize();
			}
			set
			{
				setSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual long getSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.ZipEntry.staticClass, "getSize", "()J", ref global::java.util.zip.ZipEntry._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setSize(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setSize", "(J)V", ref global::java.util.zip.ZipEntry._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isDirectory()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.ZipEntry.staticClass, "isDirectory", "()Z", ref global::java.util.zip.ZipEntry._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setTime", "(J)V", ref global::java.util.zip.ZipEntry._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Time
		{
			get
			{
				return getTime();
			}
			set
			{
				setTime(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual long getTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.ZipEntry.staticClass, "getTime", "()J", ref global::java.util.zip.ZipEntry._m9);
		}
		public new long CompressedSize
		{
			get
			{
				return getCompressedSize();
			}
			set
			{
				setCompressedSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual long getCompressedSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.ZipEntry.staticClass, "getCompressedSize", "()J", ref global::java.util.zip.ZipEntry._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setCompressedSize(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setCompressedSize", "(J)V", ref global::java.util.zip.ZipEntry._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setCrc(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setCrc", "(J)V", ref global::java.util.zip.ZipEntry._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Crc
		{
			get
			{
				return getCrc();
			}
			set
			{
				setCrc(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual long getCrc()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.ZipEntry.staticClass, "getCrc", "()J", ref global::java.util.zip.ZipEntry._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setMethod(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setMethod", "(I)V", ref global::java.util.zip.ZipEntry._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setExtra(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setExtra", "([B)V", ref global::java.util.zip.ZipEntry._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new byte[] Extra
		{
			get
			{
				return getExtra();
			}
			set
			{
				setExtra(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual byte[] getExtra()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.util.zip.ZipEntry.staticClass, "getExtra", "()[B", ref global::java.util.zip.ZipEntry._m16) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setComment", "(Ljava/lang/String;)V", ref global::java.util.zip.ZipEntry._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Comment
		{
			get
			{
				return getComment();
			}
			set
			{
				setComment(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.zip.ZipEntry.staticClass, "getComment", "()Ljava/lang/String;", ref global::java.util.zip.ZipEntry._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public ZipEntry(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipEntry._m19.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipEntry._m19 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public ZipEntry(java.util.zip.ZipEntry arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipEntry._m20.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipEntry._m20 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "<init>", "(Ljava/util/zip/ZipEntry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int STORED
		{
			get
			{
				return 0;
			}
		}
		public static int DEFLATED
		{
			get
			{
				return 8;
			}
		}
		static ZipEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipEntry"));
		}
	}
}
