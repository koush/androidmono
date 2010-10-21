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
		internal static global::MonoJavaBridge.MethodId _toString28314;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry._toString28314)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._toString28314)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode28315;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipEntry._hashCode28315);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._hashCode28315);
		}
		internal static global::MonoJavaBridge.MethodId _clone28316;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry._clone28316)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._clone28316)) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName28317;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getName28317)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getName28317)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getMethod28318;
		public virtual int getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getMethod28318);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getMethod28318);
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
		internal static global::MonoJavaBridge.MethodId _getSize28319;
		public virtual long getSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getSize28319);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getSize28319);
		}
		internal static global::MonoJavaBridge.MethodId _setSize28320;
		public virtual void setSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setSize28320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setSize28320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirectory28321;
		public virtual bool isDirectory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.ZipEntry._isDirectory28321);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._isDirectory28321);
		}
		internal static global::MonoJavaBridge.MethodId _setTime28322;
		public virtual void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setTime28322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setTime28322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTime28323;
		public virtual long getTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getTime28323);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getTime28323);
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
		internal static global::MonoJavaBridge.MethodId _getCompressedSize28324;
		public virtual long getCompressedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getCompressedSize28324);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getCompressedSize28324);
		}
		internal static global::MonoJavaBridge.MethodId _setCompressedSize28325;
		public virtual void setCompressedSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setCompressedSize28325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setCompressedSize28325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCrc28326;
		public virtual void setCrc(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setCrc28326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setCrc28326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCrc28327;
		public virtual long getCrc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getCrc28327);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getCrc28327);
		}
		internal static global::MonoJavaBridge.MethodId _setMethod28328;
		public virtual void setMethod(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setMethod28328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setMethod28328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtra28329;
		public virtual void setExtra(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setExtra28329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setExtra28329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getExtra28330;
		public virtual byte[] getExtra() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getExtra28330)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getExtra28330)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _setComment28331;
		public virtual void setComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry._setComment28331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._setComment28331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getComment28332;
		public virtual global::java.lang.String getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry._getComment28332)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._getComment28332)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ZipEntry28333;
		public ZipEntry(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ZipEntry28333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZipEntry28334;
		public ZipEntry(java.util.zip.ZipEntry arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ZipEntry28334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::java.util.zip.ZipEntry._toString28314 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.zip.ZipEntry._hashCode28315 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "hashCode", "()I");
			global::java.util.zip.ZipEntry._clone28316 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.zip.ZipEntry._getName28317 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getName", "()Ljava/lang/String;");
			global::java.util.zip.ZipEntry._getMethod28318 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getMethod", "()I");
			global::java.util.zip.ZipEntry._getSize28319 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getSize", "()J");
			global::java.util.zip.ZipEntry._setSize28320 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setSize", "(J)V");
			global::java.util.zip.ZipEntry._isDirectory28321 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "isDirectory", "()Z");
			global::java.util.zip.ZipEntry._setTime28322 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setTime", "(J)V");
			global::java.util.zip.ZipEntry._getTime28323 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getTime", "()J");
			global::java.util.zip.ZipEntry._getCompressedSize28324 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getCompressedSize", "()J");
			global::java.util.zip.ZipEntry._setCompressedSize28325 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setCompressedSize", "(J)V");
			global::java.util.zip.ZipEntry._setCrc28326 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setCrc", "(J)V");
			global::java.util.zip.ZipEntry._getCrc28327 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getCrc", "()J");
			global::java.util.zip.ZipEntry._setMethod28328 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setMethod", "(I)V");
			global::java.util.zip.ZipEntry._setExtra28329 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setExtra", "([B)V");
			global::java.util.zip.ZipEntry._getExtra28330 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getExtra", "()[B");
			global::java.util.zip.ZipEntry._setComment28331 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::java.util.zip.ZipEntry._getComment28332 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "getComment", "()Ljava/lang/String;");
			global::java.util.zip.ZipEntry._ZipEntry28333 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.zip.ZipEntry._ZipEntry28334 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "<init>", "(Ljava/util/zip/ZipEntry;)V");
		}
	}
}
