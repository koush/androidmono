namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipEntry : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ZipEntry()
		{
			InitJNI();
		}
		protected ZipEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22431;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry._toString22431)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._toString22431)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22432;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipEntry._hashCode22432);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._hashCode22432);
		}
		internal static global::MonoJavaBridge.MethodId _clone22433;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry._clone22433)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._clone22433)) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName22434;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getName22434)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getName22434)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getMethod22435;
		public virtual int getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getMethod22435);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getMethod22435);
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
		internal static global::MonoJavaBridge.MethodId _getSize22436;
		public virtual long getSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getSize22436);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getSize22436);
		}
		internal static global::MonoJavaBridge.MethodId _setSize22437;
		public virtual void setSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setSize22437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setSize22437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirectory22438;
		public virtual bool isDirectory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.ZipEntry._isDirectory22438);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._isDirectory22438);
		}
		internal static global::MonoJavaBridge.MethodId _setTime22439;
		public virtual void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setTime22439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setTime22439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTime22440;
		public virtual long getTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getTime22440);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getTime22440);
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
		internal static global::MonoJavaBridge.MethodId _getCompressedSize22441;
		public virtual long getCompressedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getCompressedSize22441);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getCompressedSize22441);
		}
		internal static global::MonoJavaBridge.MethodId _setCompressedSize22442;
		public virtual void setCompressedSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setCompressedSize22442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setCompressedSize22442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCrc22443;
		public virtual void setCrc(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setCrc22443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setCrc22443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCrc22444;
		public virtual long getCrc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getCrc22444);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getCrc22444);
		}
		internal static global::MonoJavaBridge.MethodId _setMethod22445;
		public virtual void setMethod(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setMethod22445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setMethod22445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtra22446;
		public virtual void setExtra(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setExtra22446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setExtra22446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getExtra22447;
		public virtual byte[] getExtra() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getExtra22447)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getExtra22447)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _setComment22448;
		public virtual void setComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setComment22448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setComment22448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getComment22449;
		public virtual global::java.lang.String getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getComment22449)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getComment22449)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ZipEntry22450;
		public ZipEntry(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ZipEntry22450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZipEntry22451;
		public ZipEntry(java.util.zip.ZipEntry arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ZipEntry22451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipEntry"));
			global::java.util.zip.ZipEntry._toString22431 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.zip.ZipEntry._hashCode22432 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "hashCode", "()I");
			global::java.util.zip.ZipEntry._clone22433 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.zip.ZipEntry._getName22434 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getName", "()Ljava/lang/String;");
			global::java.util.zip.ZipEntry._getMethod22435 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getMethod", "()I");
			global::java.util.zip.ZipEntry._getSize22436 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getSize", "()J");
			global::java.util.zip.ZipEntry._setSize22437 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setSize", "(J)V");
			global::java.util.zip.ZipEntry._isDirectory22438 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "isDirectory", "()Z");
			global::java.util.zip.ZipEntry._setTime22439 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setTime", "(J)V");
			global::java.util.zip.ZipEntry._getTime22440 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getTime", "()J");
			global::java.util.zip.ZipEntry._getCompressedSize22441 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getCompressedSize", "()J");
			global::java.util.zip.ZipEntry._setCompressedSize22442 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setCompressedSize", "(J)V");
			global::java.util.zip.ZipEntry._setCrc22443 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setCrc", "(J)V");
			global::java.util.zip.ZipEntry._getCrc22444 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getCrc", "()J");
			global::java.util.zip.ZipEntry._setMethod22445 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setMethod", "(I)V");
			global::java.util.zip.ZipEntry._setExtra22446 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setExtra", "([B)V");
			global::java.util.zip.ZipEntry._getExtra22447 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getExtra", "()[B");
			global::java.util.zip.ZipEntry._setComment22448 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::java.util.zip.ZipEntry._getComment22449 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getComment", "()Ljava/lang/String;");
			global::java.util.zip.ZipEntry._ZipEntry22450 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.zip.ZipEntry._ZipEntry22451 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "<init>", "(Ljava/util/zip/ZipEntry;)V");
		}
	}
}
