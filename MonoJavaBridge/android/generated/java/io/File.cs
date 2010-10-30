namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class File : java.lang.Object, Serializable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected File(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.io.File._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.File.staticClass, "toString", "()Ljava/lang/String;", ref global::java.io.File._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.File.staticClass, "hashCode", "()I", ref global::java.io.File._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int compareTo(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.File.staticClass, "compareTo", "(Ljava/io/File;)I", ref global::java.io.File._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.File.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.io.File._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.File.staticClass, "getName", "()Ljava/lang/String;", ref global::java.io.File._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual long length()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.File.staticClass, "length", "()J", ref global::java.io.File._m6);
		}
		public new global::java.lang.String Parent
		{
			get
			{
				return getParent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.File.staticClass, "getParent", "()Ljava/lang/String;", ref global::java.io.File._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isAbsolute()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "isAbsolute", "()Z", ref global::java.io.File._m8);
		}
		public new global::java.lang.String CanonicalPath
		{
			get
			{
				return getCanonicalPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getCanonicalPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.File.staticClass, "getCanonicalPath", "()Ljava/lang/String;", ref global::java.io.File._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool setReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "setReadOnly", "()Z", ref global::java.io.File._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String[] list(java.io.FilenameFilter arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.io.File.staticClass, "list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;", ref global::java.io.File._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.String[] list()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.io.File.staticClass, "list", "()[Ljava/lang/String;", ref global::java.io.File._m12) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool delete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "delete", "()Z", ref global::java.io.File._m13);
		}
		public new global::java.io.File ParentFile
		{
			get
			{
				return getParentFile();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.io.File getParentFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, "getParentFile", "()Ljava/io/File;", ref global::java.io.File._m14) as java.io.File;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.File.staticClass, "getPath", "()Ljava/lang/String;", ref global::java.io.File._m15) as java.lang.String;
		}
		public new global::java.lang.String AbsolutePath
		{
			get
			{
				return getAbsolutePath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.String getAbsolutePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.File.staticClass, "getAbsolutePath", "()Ljava/lang/String;", ref global::java.io.File._m16) as java.lang.String;
		}
		public new global::java.io.File AbsoluteFile
		{
			get
			{
				return getAbsoluteFile();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.io.File getAbsoluteFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, "getAbsoluteFile", "()Ljava/io/File;", ref global::java.io.File._m17) as java.io.File;
		}
		public new global::java.io.File CanonicalFile
		{
			get
			{
				return getCanonicalFile();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.io.File getCanonicalFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, "getCanonicalFile", "()Ljava/io/File;", ref global::java.io.File._m18) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.net.URL toURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.io.File.staticClass, "toURL", "()Ljava/net/URL;", ref global::java.io.File._m19) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.net.URI toURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::java.io.File.staticClass, "toURI", "()Ljava/net/URI;", ref global::java.io.File._m20) as java.net.URI;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool canRead()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "canRead", "()Z", ref global::java.io.File._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool canWrite()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "canWrite", "()Z", ref global::java.io.File._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool exists()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "exists", "()Z", ref global::java.io.File._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool isDirectory()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "isDirectory", "()Z", ref global::java.io.File._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool isFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "isFile", "()Z", ref global::java.io.File._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool isHidden()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "isHidden", "()Z", ref global::java.io.File._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual long lastModified()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.File.staticClass, "lastModified", "()J", ref global::java.io.File._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool createNewFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "createNewFile", "()Z", ref global::java.io.File._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void deleteOnExit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.File.staticClass, "deleteOnExit", "()V", ref global::java.io.File._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual global::java.io.File[] listFiles(java.io.FileFilter arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.io.File>(this, global::java.io.File.staticClass, "listFiles", "(Ljava/io/FileFilter;)[Ljava/io/File;", ref global::java.io.File._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File[];
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::java.io.File[] listFiles()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.io.File>(this, global::java.io.File.staticClass, "listFiles", "()[Ljava/io/File;", ref global::java.io.File._m31) as java.io.File[];
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::java.io.File[] listFiles(java.io.FilenameFilter arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.io.File>(this, global::java.io.File.staticClass, "listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;", ref global::java.io.File._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File[];
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual bool mkdir()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "mkdir", "()Z", ref global::java.io.File._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual bool mkdirs()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "mkdirs", "()Z", ref global::java.io.File._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual bool renameTo(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "renameTo", "(Ljava/io/File;)Z", ref global::java.io.File._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual bool setLastModified(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "setLastModified", "(J)Z", ref global::java.io.File._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool setWritable(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "setWritable", "(ZZ)Z", ref global::java.io.File._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool Writable
		{
			set
			{
				setWritable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual bool setWritable(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "setWritable", "(Z)Z", ref global::java.io.File._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual bool setReadable(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "setReadable", "(ZZ)Z", ref global::java.io.File._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool Readable
		{
			set
			{
				setReadable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual bool setReadable(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "setReadable", "(Z)Z", ref global::java.io.File._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual bool setExecutable(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "setExecutable", "(ZZ)Z", ref global::java.io.File._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool Executable
		{
			set
			{
				setExecutable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual bool setExecutable(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "setExecutable", "(Z)Z", ref global::java.io.File._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual bool canExecute()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, "canExecute", "()Z", ref global::java.io.File._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static global::java.io.File[] listRoots()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.File._m44.native == global::System.IntPtr.Zero)
				global::java.io.File._m44 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "listRoots", "()[Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._m44)) as java.io.File[];
		}
		public new long TotalSpace
		{
			get
			{
				return getTotalSpace();
			}
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual long getTotalSpace()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.File.staticClass, "getTotalSpace", "()J", ref global::java.io.File._m45);
		}
		public new long FreeSpace
		{
			get
			{
				return getFreeSpace();
			}
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual long getFreeSpace()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.File.staticClass, "getFreeSpace", "()J", ref global::java.io.File._m46);
		}
		public new long UsableSpace
		{
			get
			{
				return getUsableSpace();
			}
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual long getUsableSpace()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.File.staticClass, "getUsableSpace", "()J", ref global::java.io.File._m47);
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static global::java.io.File createTempFile(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.File._m48.native == global::System.IntPtr.Zero)
				global::java.io.File._m48 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public static global::java.io.File createTempFile(java.lang.String arg0, java.lang.String arg1, java.io.File arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.File._m49.native == global::System.IntPtr.Zero)
				global::java.io.File._m49 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public File(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.File._m50.native == global::System.IntPtr.Zero)
				global::java.io.File._m50 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public File(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.File._m51.native == global::System.IntPtr.Zero)
				global::java.io.File._m51 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public File(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.File._m52.native == global::System.IntPtr.Zero)
				global::java.io.File._m52 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public File(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.File._m53.native == global::System.IntPtr.Zero)
				global::java.io.File._m53 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		static File()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.File.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/File"));
		}
		internal static void InitJNI()
		{
		}
	}
}
