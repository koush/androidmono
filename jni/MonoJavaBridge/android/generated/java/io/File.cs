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
		internal static global::MonoJavaBridge.MethodId _equals18834;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._equals18834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._equals18834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString18835;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._toString18835)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._toString18835)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18836;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.File._hashCode18836);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._hashCode18836);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo18837;
		public virtual int compareTo(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.File._compareTo18837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._compareTo18837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo18838;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.File._compareTo18838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._compareTo18838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName18839;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getName18839)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getName18839)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length18840;
		public virtual long length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._length18840);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._length18840);
		}
		public new global::java.lang.String Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent18841;
		public virtual global::java.lang.String getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getParent18841)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getParent18841)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute18842;
		public virtual bool isAbsolute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isAbsolute18842);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isAbsolute18842);
		}
		public new global::java.lang.String CanonicalPath
		{
			get
			{
				return getCanonicalPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalPath18843;
		public virtual global::java.lang.String getCanonicalPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getCanonicalPath18843)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getCanonicalPath18843)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly18844;
		public virtual bool setReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setReadOnly18844);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setReadOnly18844);
		}
		internal static global::MonoJavaBridge.MethodId _list18845;
		public virtual global::java.lang.String[] list(java.io.FilenameFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._list18845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._list18845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _list18846;
		public virtual global::java.lang.String[] list() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._list18846)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._list18846)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _delete18847;
		public virtual bool delete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._delete18847);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._delete18847);
		}
		public new global::java.io.File ParentFile
		{
			get
			{
				return getParentFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParentFile18848;
		public virtual global::java.io.File getParentFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getParentFile18848)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getParentFile18848)) as java.io.File;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath18849;
		public virtual global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getPath18849)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getPath18849)) as java.lang.String;
		}
		public new global::java.lang.String AbsolutePath
		{
			get
			{
				return getAbsolutePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAbsolutePath18850;
		public virtual global::java.lang.String getAbsolutePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getAbsolutePath18850)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getAbsolutePath18850)) as java.lang.String;
		}
		public new global::java.io.File AbsoluteFile
		{
			get
			{
				return getAbsoluteFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAbsoluteFile18851;
		public virtual global::java.io.File getAbsoluteFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getAbsoluteFile18851)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getAbsoluteFile18851)) as java.io.File;
		}
		public new global::java.io.File CanonicalFile
		{
			get
			{
				return getCanonicalFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalFile18852;
		public virtual global::java.io.File getCanonicalFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._getCanonicalFile18852)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getCanonicalFile18852)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _toURL18853;
		public virtual global::java.net.URL toURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._toURL18853)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._toURL18853)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _toURI18854;
		public virtual global::java.net.URI toURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._toURI18854)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._toURI18854)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _canRead18855;
		public virtual bool canRead() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._canRead18855);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._canRead18855);
		}
		internal static global::MonoJavaBridge.MethodId _canWrite18856;
		public virtual bool canWrite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._canWrite18856);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._canWrite18856);
		}
		internal static global::MonoJavaBridge.MethodId _exists18857;
		public virtual bool exists() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._exists18857);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._exists18857);
		}
		internal static global::MonoJavaBridge.MethodId _isDirectory18858;
		public virtual bool isDirectory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isDirectory18858);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isDirectory18858);
		}
		internal static global::MonoJavaBridge.MethodId _isFile18859;
		public virtual bool isFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isFile18859);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isFile18859);
		}
		internal static global::MonoJavaBridge.MethodId _isHidden18860;
		public virtual bool isHidden() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._isHidden18860);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._isHidden18860);
		}
		internal static global::MonoJavaBridge.MethodId _lastModified18861;
		public virtual long lastModified() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._lastModified18861);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._lastModified18861);
		}
		internal static global::MonoJavaBridge.MethodId _createNewFile18862;
		public virtual bool createNewFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._createNewFile18862);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._createNewFile18862);
		}
		internal static global::MonoJavaBridge.MethodId _deleteOnExit18863;
		public virtual void deleteOnExit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.File._deleteOnExit18863);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._deleteOnExit18863);
		}
		internal static global::MonoJavaBridge.MethodId _listFiles18864;
		public virtual global::java.io.File[] listFiles(java.io.FileFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._listFiles18864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._listFiles18864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _listFiles18865;
		public virtual global::java.io.File[] listFiles() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._listFiles18865)) as java.io.File[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._listFiles18865)) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _listFiles18866;
		public virtual global::java.io.File[] listFiles(java.io.FilenameFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.File._listFiles18866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._listFiles18866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _mkdir18867;
		public virtual bool mkdir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._mkdir18867);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._mkdir18867);
		}
		internal static global::MonoJavaBridge.MethodId _mkdirs18868;
		public virtual bool mkdirs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._mkdirs18868);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._mkdirs18868);
		}
		internal static global::MonoJavaBridge.MethodId _renameTo18869;
		public virtual bool renameTo(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._renameTo18869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._renameTo18869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLastModified18870;
		public virtual bool setLastModified(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setLastModified18870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setLastModified18870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWritable18871;
		public virtual bool setWritable(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setWritable18871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setWritable18871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setWritable18872;
		public virtual bool setWritable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setWritable18872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setWritable18872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setReadable18873;
		public virtual bool setReadable(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setReadable18873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setReadable18873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setReadable18874;
		public virtual bool setReadable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setReadable18874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setReadable18874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExecutable18875;
		public virtual bool setExecutable(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setExecutable18875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setExecutable18875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setExecutable18876;
		public virtual bool setExecutable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._setExecutable18876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._setExecutable18876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _canExecute18877;
		public virtual bool canExecute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.File._canExecute18877);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._canExecute18877);
		}
		internal static global::MonoJavaBridge.MethodId _listRoots18878;
		public static global::java.io.File[] listRoots() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._listRoots18878)) as java.io.File[];
		}
		public new long TotalSpace
		{
			get
			{
				return getTotalSpace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalSpace18879;
		public virtual long getTotalSpace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._getTotalSpace18879);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getTotalSpace18879);
		}
		public new long FreeSpace
		{
			get
			{
				return getFreeSpace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFreeSpace18880;
		public virtual long getFreeSpace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._getFreeSpace18880);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getFreeSpace18880);
		}
		public new long UsableSpace
		{
			get
			{
				return getUsableSpace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUsableSpace18881;
		public virtual long getUsableSpace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.File._getUsableSpace18881);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.File.staticClass, global::java.io.File._getUsableSpace18881);
		}
		internal static global::MonoJavaBridge.MethodId _createTempFile18882;
		public static global::java.io.File createTempFile(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._createTempFile18882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _createTempFile18883;
		public static global::java.io.File createTempFile(java.lang.String arg0, java.lang.String arg1, java.io.File arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._createTempFile18883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _File18884;
		public File(java.net.URI arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File18884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File18885;
		public File(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File18885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File18886;
		public File(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File18886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File18887;
		public File(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File18887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::java.io.File._equals18834 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.io.File._toString18835 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.File._hashCode18836 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "hashCode", "()I");
			global::java.io.File._compareTo18837 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "compareTo", "(Ljava/io/File;)I");
			global::java.io.File._compareTo18838 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.io.File._getName18839 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getName", "()Ljava/lang/String;");
			global::java.io.File._length18840 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "length", "()J");
			global::java.io.File._getParent18841 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getParent", "()Ljava/lang/String;");
			global::java.io.File._isAbsolute18842 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isAbsolute", "()Z");
			global::java.io.File._getCanonicalPath18843 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getCanonicalPath", "()Ljava/lang/String;");
			global::java.io.File._setReadOnly18844 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadOnly", "()Z");
			global::java.io.File._list18845 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;");
			global::java.io.File._list18846 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "list", "()[Ljava/lang/String;");
			global::java.io.File._delete18847 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "delete", "()Z");
			global::java.io.File._getParentFile18848 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getParentFile", "()Ljava/io/File;");
			global::java.io.File._getPath18849 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.io.File._getAbsolutePath18850 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getAbsolutePath", "()Ljava/lang/String;");
			global::java.io.File._getAbsoluteFile18851 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getAbsoluteFile", "()Ljava/io/File;");
			global::java.io.File._getCanonicalFile18852 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getCanonicalFile", "()Ljava/io/File;");
			global::java.io.File._toURL18853 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toURL", "()Ljava/net/URL;");
			global::java.io.File._toURI18854 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toURI", "()Ljava/net/URI;");
			global::java.io.File._canRead18855 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canRead", "()Z");
			global::java.io.File._canWrite18856 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canWrite", "()Z");
			global::java.io.File._exists18857 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "exists", "()Z");
			global::java.io.File._isDirectory18858 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isDirectory", "()Z");
			global::java.io.File._isFile18859 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isFile", "()Z");
			global::java.io.File._isHidden18860 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isHidden", "()Z");
			global::java.io.File._lastModified18861 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "lastModified", "()J");
			global::java.io.File._createNewFile18862 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "createNewFile", "()Z");
			global::java.io.File._deleteOnExit18863 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "deleteOnExit", "()V");
			global::java.io.File._listFiles18864 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "(Ljava/io/FileFilter;)[Ljava/io/File;");
			global::java.io.File._listFiles18865 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "()[Ljava/io/File;");
			global::java.io.File._listFiles18866 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;");
			global::java.io.File._mkdir18867 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "mkdir", "()Z");
			global::java.io.File._mkdirs18868 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "mkdirs", "()Z");
			global::java.io.File._renameTo18869 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "renameTo", "(Ljava/io/File;)Z");
			global::java.io.File._setLastModified18870 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setLastModified", "(J)Z");
			global::java.io.File._setWritable18871 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setWritable", "(ZZ)Z");
			global::java.io.File._setWritable18872 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setWritable", "(Z)Z");
			global::java.io.File._setReadable18873 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadable", "(ZZ)Z");
			global::java.io.File._setReadable18874 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadable", "(Z)Z");
			global::java.io.File._setExecutable18875 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setExecutable", "(ZZ)Z");
			global::java.io.File._setExecutable18876 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setExecutable", "(Z)Z");
			global::java.io.File._canExecute18877 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canExecute", "()Z");
			global::java.io.File._listRoots18878 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "listRoots", "()[Ljava/io/File;");
			global::java.io.File._getTotalSpace18879 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getTotalSpace", "()J");
			global::java.io.File._getFreeSpace18880 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getFreeSpace", "()J");
			global::java.io.File._getUsableSpace18881 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getUsableSpace", "()J");
			global::java.io.File._createTempFile18882 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;");
			global::java.io.File._createTempFile18883 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;");
			global::java.io.File._File18884 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::java.io.File._File18885 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.File._File18886 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.File._File18887 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
		}
	}
}
