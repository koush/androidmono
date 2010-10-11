namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class File : java.lang.Object, Serializable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static File()
		{
			InitJNI();
		}
		protected File(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12495;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._equals12495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._equals12495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12496;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._toString12496)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._toString12496)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12497;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.File._hashCode12497);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._hashCode12497);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12498;
		public virtual int compareTo(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.File._compareTo12498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._compareTo12498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12499;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.File._compareTo12499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._compareTo12499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName12500;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getName12500)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getName12500)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12501;
		public virtual long length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._length12501);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._length12501);
		}
		internal static global::MonoJavaBridge.MethodId _getParent12502;
		public virtual global::java.lang.String getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getParent12502)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getParent12502)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute12503;
		public virtual bool isAbsolute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isAbsolute12503);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isAbsolute12503);
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalPath12504;
		public virtual global::java.lang.String getCanonicalPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getCanonicalPath12504)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getCanonicalPath12504)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly12505;
		public virtual bool setReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setReadOnly12505);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setReadOnly12505);
		}
		internal static global::MonoJavaBridge.MethodId _list12506;
		public virtual global::java.lang.String[] list(java.io.FilenameFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._list12506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._list12506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _list12507;
		public virtual global::java.lang.String[] list() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._list12507)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._list12507)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _delete12508;
		public virtual bool delete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._delete12508);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._delete12508);
		}
		internal static global::MonoJavaBridge.MethodId _getParentFile12509;
		public virtual global::java.io.File getParentFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getParentFile12509)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getParentFile12509)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getPath12510;
		public virtual global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getPath12510)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getPath12510)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAbsolutePath12511;
		public virtual global::java.lang.String getAbsolutePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getAbsolutePath12511)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getAbsolutePath12511)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAbsoluteFile12512;
		public virtual global::java.io.File getAbsoluteFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getAbsoluteFile12512)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getAbsoluteFile12512)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalFile12513;
		public virtual global::java.io.File getCanonicalFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getCanonicalFile12513)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getCanonicalFile12513)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _toURL12514;
		public virtual global::java.net.URL toURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._toURL12514)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._toURL12514)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _toURI12515;
		public virtual global::java.net.URI toURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._toURI12515)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._toURI12515)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _canRead12516;
		public virtual bool canRead() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._canRead12516);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._canRead12516);
		}
		internal static global::MonoJavaBridge.MethodId _canWrite12517;
		public virtual bool canWrite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._canWrite12517);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._canWrite12517);
		}
		internal static global::MonoJavaBridge.MethodId _exists12518;
		public virtual bool exists() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._exists12518);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._exists12518);
		}
		internal static global::MonoJavaBridge.MethodId _isDirectory12519;
		public virtual bool isDirectory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isDirectory12519);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isDirectory12519);
		}
		internal static global::MonoJavaBridge.MethodId _isFile12520;
		public virtual bool isFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isFile12520);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isFile12520);
		}
		internal static global::MonoJavaBridge.MethodId _isHidden12521;
		public virtual bool isHidden() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isHidden12521);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isHidden12521);
		}
		internal static global::MonoJavaBridge.MethodId _lastModified12522;
		public virtual long lastModified() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._lastModified12522);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._lastModified12522);
		}
		internal static global::MonoJavaBridge.MethodId _createNewFile12523;
		public virtual bool createNewFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._createNewFile12523);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._createNewFile12523);
		}
		internal static global::MonoJavaBridge.MethodId _deleteOnExit12524;
		public virtual void deleteOnExit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.File._deleteOnExit12524);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._deleteOnExit12524);
		}
		internal static global::MonoJavaBridge.MethodId _listFiles12525;
		public virtual global::java.io.File[] listFiles(java.io.FileFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._listFiles12525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._listFiles12525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _listFiles12526;
		public virtual global::java.io.File[] listFiles() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._listFiles12526)) as java.io.File[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._listFiles12526)) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _listFiles12527;
		public virtual global::java.io.File[] listFiles(java.io.FilenameFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._listFiles12527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._listFiles12527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _mkdir12528;
		public virtual bool mkdir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._mkdir12528);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._mkdir12528);
		}
		internal static global::MonoJavaBridge.MethodId _mkdirs12529;
		public virtual bool mkdirs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._mkdirs12529);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._mkdirs12529);
		}
		internal static global::MonoJavaBridge.MethodId _renameTo12530;
		public virtual bool renameTo(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._renameTo12530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._renameTo12530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLastModified12531;
		public virtual bool setLastModified(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setLastModified12531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setLastModified12531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWritable12532;
		public virtual bool setWritable(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setWritable12532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setWritable12532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setWritable12533;
		public virtual bool setWritable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setWritable12533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setWritable12533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setReadable12534;
		public virtual bool setReadable(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setReadable12534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setReadable12534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setReadable12535;
		public virtual bool setReadable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setReadable12535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setReadable12535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExecutable12536;
		public virtual bool setExecutable(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setExecutable12536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setExecutable12536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setExecutable12537;
		public virtual bool setExecutable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setExecutable12537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setExecutable12537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _canExecute12538;
		public virtual bool canExecute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._canExecute12538);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._canExecute12538);
		}
		internal static global::MonoJavaBridge.MethodId _listRoots12539;
		public static global::java.io.File[] listRoots() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._listRoots12539)) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _getTotalSpace12540;
		public virtual long getTotalSpace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._getTotalSpace12540);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getTotalSpace12540);
		}
		internal static global::MonoJavaBridge.MethodId _getFreeSpace12541;
		public virtual long getFreeSpace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._getFreeSpace12541);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getFreeSpace12541);
		}
		internal static global::MonoJavaBridge.MethodId _getUsableSpace12542;
		public virtual long getUsableSpace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._getUsableSpace12542);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getUsableSpace12542);
		}
		internal static global::MonoJavaBridge.MethodId _createTempFile12543;
		public static global::java.io.File createTempFile(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._createTempFile12543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _createTempFile12544;
		public static global::java.io.File createTempFile(java.lang.String arg0, java.lang.String arg1, java.io.File arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._createTempFile12544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _File12545;
		public File(java.net.URI arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File12545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File12546;
		public File(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File12546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File12547;
		public File(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File12547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File12548;
		public File(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File12548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static char separatorChar
		{
			get
			{
				return '/';
			}
		}
		public static global::java.lang.String separator
		{
			get
			{
				return "/";
			}
		}
		public static char pathSeparatorChar
		{
			get
			{
				return ':';
			}
		}
		public static global::java.lang.String pathSeparator
		{
			get
			{
				return ":";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.File.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/File"));
			global::java.io.File._equals12495 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.io.File._toString12496 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.File._hashCode12497 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "hashCode", "()I");
			global::java.io.File._compareTo12498 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "compareTo", "(Ljava/io/File;)I");
			global::java.io.File._compareTo12499 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.io.File._getName12500 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getName", "()Ljava/lang/String;");
			global::java.io.File._length12501 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "length", "()J");
			global::java.io.File._getParent12502 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getParent", "()Ljava/lang/String;");
			global::java.io.File._isAbsolute12503 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isAbsolute", "()Z");
			global::java.io.File._getCanonicalPath12504 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getCanonicalPath", "()Ljava/lang/String;");
			global::java.io.File._setReadOnly12505 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadOnly", "()Z");
			global::java.io.File._list12506 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;");
			global::java.io.File._list12507 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "list", "()[Ljava/lang/String;");
			global::java.io.File._delete12508 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "delete", "()Z");
			global::java.io.File._getParentFile12509 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getParentFile", "()Ljava/io/File;");
			global::java.io.File._getPath12510 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.io.File._getAbsolutePath12511 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getAbsolutePath", "()Ljava/lang/String;");
			global::java.io.File._getAbsoluteFile12512 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getAbsoluteFile", "()Ljava/io/File;");
			global::java.io.File._getCanonicalFile12513 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getCanonicalFile", "()Ljava/io/File;");
			global::java.io.File._toURL12514 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toURL", "()Ljava/net/URL;");
			global::java.io.File._toURI12515 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toURI", "()Ljava/net/URI;");
			global::java.io.File._canRead12516 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canRead", "()Z");
			global::java.io.File._canWrite12517 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canWrite", "()Z");
			global::java.io.File._exists12518 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "exists", "()Z");
			global::java.io.File._isDirectory12519 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isDirectory", "()Z");
			global::java.io.File._isFile12520 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isFile", "()Z");
			global::java.io.File._isHidden12521 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isHidden", "()Z");
			global::java.io.File._lastModified12522 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "lastModified", "()J");
			global::java.io.File._createNewFile12523 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "createNewFile", "()Z");
			global::java.io.File._deleteOnExit12524 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "deleteOnExit", "()V");
			global::java.io.File._listFiles12525 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "(Ljava/io/FileFilter;)[Ljava/io/File;");
			global::java.io.File._listFiles12526 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "()[Ljava/io/File;");
			global::java.io.File._listFiles12527 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;");
			global::java.io.File._mkdir12528 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "mkdir", "()Z");
			global::java.io.File._mkdirs12529 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "mkdirs", "()Z");
			global::java.io.File._renameTo12530 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "renameTo", "(Ljava/io/File;)Z");
			global::java.io.File._setLastModified12531 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setLastModified", "(J)Z");
			global::java.io.File._setWritable12532 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setWritable", "(ZZ)Z");
			global::java.io.File._setWritable12533 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setWritable", "(Z)Z");
			global::java.io.File._setReadable12534 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadable", "(ZZ)Z");
			global::java.io.File._setReadable12535 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadable", "(Z)Z");
			global::java.io.File._setExecutable12536 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setExecutable", "(ZZ)Z");
			global::java.io.File._setExecutable12537 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setExecutable", "(Z)Z");
			global::java.io.File._canExecute12538 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canExecute", "()Z");
			global::java.io.File._listRoots12539 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "listRoots", "()[Ljava/io/File;");
			global::java.io.File._getTotalSpace12540 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getTotalSpace", "()J");
			global::java.io.File._getFreeSpace12541 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getFreeSpace", "()J");
			global::java.io.File._getUsableSpace12542 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getUsableSpace", "()J");
			global::java.io.File._createTempFile12543 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;");
			global::java.io.File._createTempFile12544 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;");
			global::java.io.File._File12545 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::java.io.File._File12546 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.File._File12547 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.File._File12548 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
		}
	}
}
