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
		internal static global::MonoJavaBridge.MethodId _equals13363;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._equals13363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._equals13363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13364;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._toString13364)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._toString13364)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13365;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.File._hashCode13365);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._hashCode13365);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo13366;
		public virtual int compareTo(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.File._compareTo13366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._compareTo13366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo13367;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.File._compareTo13367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._compareTo13367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName13368;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getName13368)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getName13368)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length13369;
		public virtual long length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._length13369);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._length13369);
		}
		public new global::java.lang.String Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent13370;
		public virtual global::java.lang.String getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getParent13370)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getParent13370)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute13371;
		public virtual bool isAbsolute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isAbsolute13371);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isAbsolute13371);
		}
		public new global::java.lang.String CanonicalPath
		{
			get
			{
				return getCanonicalPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalPath13372;
		public virtual global::java.lang.String getCanonicalPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getCanonicalPath13372)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getCanonicalPath13372)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly13373;
		public virtual bool setReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setReadOnly13373);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setReadOnly13373);
		}
		internal static global::MonoJavaBridge.MethodId _list13374;
		public virtual global::java.lang.String[] list(java.io.FilenameFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._list13374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._list13374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _list13375;
		public virtual global::java.lang.String[] list() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._list13375)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._list13375)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _delete13376;
		public virtual bool delete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._delete13376);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._delete13376);
		}
		public new global::java.io.File ParentFile
		{
			get
			{
				return getParentFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParentFile13377;
		public virtual global::java.io.File getParentFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getParentFile13377)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getParentFile13377)) as java.io.File;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath13378;
		public virtual global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getPath13378)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getPath13378)) as java.lang.String;
		}
		public new global::java.lang.String AbsolutePath
		{
			get
			{
				return getAbsolutePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAbsolutePath13379;
		public virtual global::java.lang.String getAbsolutePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getAbsolutePath13379)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getAbsolutePath13379)) as java.lang.String;
		}
		public new global::java.io.File AbsoluteFile
		{
			get
			{
				return getAbsoluteFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAbsoluteFile13380;
		public virtual global::java.io.File getAbsoluteFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getAbsoluteFile13380)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getAbsoluteFile13380)) as java.io.File;
		}
		public new global::java.io.File CanonicalFile
		{
			get
			{
				return getCanonicalFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalFile13381;
		public virtual global::java.io.File getCanonicalFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getCanonicalFile13381)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getCanonicalFile13381)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _toURL13382;
		public virtual global::java.net.URL toURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._toURL13382)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._toURL13382)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _toURI13383;
		public virtual global::java.net.URI toURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._toURI13383)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._toURI13383)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _canRead13384;
		public virtual bool canRead() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._canRead13384);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._canRead13384);
		}
		internal static global::MonoJavaBridge.MethodId _canWrite13385;
		public virtual bool canWrite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._canWrite13385);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._canWrite13385);
		}
		internal static global::MonoJavaBridge.MethodId _exists13386;
		public virtual bool exists() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._exists13386);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._exists13386);
		}
		internal static global::MonoJavaBridge.MethodId _isDirectory13387;
		public virtual bool isDirectory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isDirectory13387);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isDirectory13387);
		}
		internal static global::MonoJavaBridge.MethodId _isFile13388;
		public virtual bool isFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isFile13388);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isFile13388);
		}
		internal static global::MonoJavaBridge.MethodId _isHidden13389;
		public virtual bool isHidden() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isHidden13389);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isHidden13389);
		}
		internal static global::MonoJavaBridge.MethodId _lastModified13390;
		public virtual long lastModified() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._lastModified13390);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._lastModified13390);
		}
		internal static global::MonoJavaBridge.MethodId _createNewFile13391;
		public virtual bool createNewFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._createNewFile13391);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._createNewFile13391);
		}
		internal static global::MonoJavaBridge.MethodId _deleteOnExit13392;
		public virtual void deleteOnExit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.File._deleteOnExit13392);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._deleteOnExit13392);
		}
		internal static global::MonoJavaBridge.MethodId _listFiles13393;
		public virtual global::java.io.File[] listFiles(java.io.FileFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._listFiles13393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._listFiles13393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _listFiles13394;
		public virtual global::java.io.File[] listFiles() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._listFiles13394)) as java.io.File[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._listFiles13394)) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _listFiles13395;
		public virtual global::java.io.File[] listFiles(java.io.FilenameFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._listFiles13395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._listFiles13395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _mkdir13396;
		public virtual bool mkdir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._mkdir13396);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._mkdir13396);
		}
		internal static global::MonoJavaBridge.MethodId _mkdirs13397;
		public virtual bool mkdirs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._mkdirs13397);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._mkdirs13397);
		}
		internal static global::MonoJavaBridge.MethodId _renameTo13398;
		public virtual bool renameTo(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._renameTo13398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._renameTo13398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLastModified13399;
		public virtual bool setLastModified(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setLastModified13399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setLastModified13399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWritable13400;
		public virtual bool setWritable(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setWritable13400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setWritable13400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setWritable13401;
		public virtual bool setWritable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setWritable13401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setWritable13401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setReadable13402;
		public virtual bool setReadable(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setReadable13402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setReadable13402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setReadable13403;
		public virtual bool setReadable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setReadable13403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setReadable13403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExecutable13404;
		public virtual bool setExecutable(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setExecutable13404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setExecutable13404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setExecutable13405;
		public virtual bool setExecutable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setExecutable13405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setExecutable13405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _canExecute13406;
		public virtual bool canExecute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._canExecute13406);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._canExecute13406);
		}
		internal static global::MonoJavaBridge.MethodId _listRoots13407;
		public static global::java.io.File[] listRoots() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._listRoots13407)) as java.io.File[];
		}
		public new long TotalSpace
		{
			get
			{
				return getTotalSpace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalSpace13408;
		public virtual long getTotalSpace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._getTotalSpace13408);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getTotalSpace13408);
		}
		public new long FreeSpace
		{
			get
			{
				return getFreeSpace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFreeSpace13409;
		public virtual long getFreeSpace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._getFreeSpace13409);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getFreeSpace13409);
		}
		public new long UsableSpace
		{
			get
			{
				return getUsableSpace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUsableSpace13410;
		public virtual long getUsableSpace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._getUsableSpace13410);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getUsableSpace13410);
		}
		internal static global::MonoJavaBridge.MethodId _createTempFile13411;
		public static global::java.io.File createTempFile(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._createTempFile13411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _createTempFile13412;
		public static global::java.io.File createTempFile(java.lang.String arg0, java.lang.String arg1, java.io.File arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._createTempFile13412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _File13413;
		public File(java.net.URI arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File13413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File13414;
		public File(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File13414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File13415;
		public File(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File13415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File13416;
		public File(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File13416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::java.io.File._equals13363 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.io.File._toString13364 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.File._hashCode13365 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "hashCode", "()I");
			global::java.io.File._compareTo13366 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "compareTo", "(Ljava/io/File;)I");
			global::java.io.File._compareTo13367 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.io.File._getName13368 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getName", "()Ljava/lang/String;");
			global::java.io.File._length13369 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "length", "()J");
			global::java.io.File._getParent13370 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getParent", "()Ljava/lang/String;");
			global::java.io.File._isAbsolute13371 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isAbsolute", "()Z");
			global::java.io.File._getCanonicalPath13372 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getCanonicalPath", "()Ljava/lang/String;");
			global::java.io.File._setReadOnly13373 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadOnly", "()Z");
			global::java.io.File._list13374 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;");
			global::java.io.File._list13375 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "list", "()[Ljava/lang/String;");
			global::java.io.File._delete13376 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "delete", "()Z");
			global::java.io.File._getParentFile13377 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getParentFile", "()Ljava/io/File;");
			global::java.io.File._getPath13378 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.io.File._getAbsolutePath13379 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getAbsolutePath", "()Ljava/lang/String;");
			global::java.io.File._getAbsoluteFile13380 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getAbsoluteFile", "()Ljava/io/File;");
			global::java.io.File._getCanonicalFile13381 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getCanonicalFile", "()Ljava/io/File;");
			global::java.io.File._toURL13382 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toURL", "()Ljava/net/URL;");
			global::java.io.File._toURI13383 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toURI", "()Ljava/net/URI;");
			global::java.io.File._canRead13384 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canRead", "()Z");
			global::java.io.File._canWrite13385 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canWrite", "()Z");
			global::java.io.File._exists13386 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "exists", "()Z");
			global::java.io.File._isDirectory13387 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isDirectory", "()Z");
			global::java.io.File._isFile13388 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isFile", "()Z");
			global::java.io.File._isHidden13389 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isHidden", "()Z");
			global::java.io.File._lastModified13390 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "lastModified", "()J");
			global::java.io.File._createNewFile13391 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "createNewFile", "()Z");
			global::java.io.File._deleteOnExit13392 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "deleteOnExit", "()V");
			global::java.io.File._listFiles13393 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "(Ljava/io/FileFilter;)[Ljava/io/File;");
			global::java.io.File._listFiles13394 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "()[Ljava/io/File;");
			global::java.io.File._listFiles13395 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;");
			global::java.io.File._mkdir13396 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "mkdir", "()Z");
			global::java.io.File._mkdirs13397 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "mkdirs", "()Z");
			global::java.io.File._renameTo13398 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "renameTo", "(Ljava/io/File;)Z");
			global::java.io.File._setLastModified13399 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setLastModified", "(J)Z");
			global::java.io.File._setWritable13400 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setWritable", "(ZZ)Z");
			global::java.io.File._setWritable13401 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setWritable", "(Z)Z");
			global::java.io.File._setReadable13402 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadable", "(ZZ)Z");
			global::java.io.File._setReadable13403 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadable", "(Z)Z");
			global::java.io.File._setExecutable13404 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setExecutable", "(ZZ)Z");
			global::java.io.File._setExecutable13405 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setExecutable", "(Z)Z");
			global::java.io.File._canExecute13406 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canExecute", "()Z");
			global::java.io.File._listRoots13407 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "listRoots", "()[Ljava/io/File;");
			global::java.io.File._getTotalSpace13408 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getTotalSpace", "()J");
			global::java.io.File._getFreeSpace13409 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getFreeSpace", "()J");
			global::java.io.File._getUsableSpace13410 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getUsableSpace", "()J");
			global::java.io.File._createTempFile13411 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;");
			global::java.io.File._createTempFile13412 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;");
			global::java.io.File._File13413 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::java.io.File._File13414 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.File._File13415 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.File._File13416 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
		}
	}
}
