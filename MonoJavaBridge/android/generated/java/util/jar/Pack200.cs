namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.jar.Pack200_))]
	public abstract partial class Pack200 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Pack200(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.jar.Pack200.Packer_))]
		public partial interface Packer  : global::MonoJavaBridge.IJavaObject 
		{
			global::java.util.SortedMap properties();
			void addPropertyChangeListener(java.beans.PropertyChangeListener arg0);
			void removePropertyChangeListener(java.beans.PropertyChangeListener arg0);
			void pack(java.util.jar.JarFile arg0, java.io.OutputStream arg1);
			void pack(java.util.jar.JarInputStream arg0, java.io.OutputStream arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.jar.Pack200.Packer))]
		internal sealed partial class Packer_ : java.lang.Object, Packer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Packer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::java.util.SortedMap java.util.jar.Pack200.Packer.properties()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.jar.Pack200.Packer_.staticClass, "properties", "()Ljava/util/SortedMap;", ref global::java.util.jar.Pack200.Packer_._m0) as java.util.SortedMap;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void java.util.jar.Pack200.Packer.addPropertyChangeListener(java.beans.PropertyChangeListener arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Pack200.Packer_.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", ref global::java.util.jar.Pack200.Packer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void java.util.jar.Pack200.Packer.removePropertyChangeListener(java.beans.PropertyChangeListener arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Pack200.Packer_.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", ref global::java.util.jar.Pack200.Packer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			void java.util.jar.Pack200.Packer.pack(java.util.jar.JarFile arg0, java.io.OutputStream arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Pack200.Packer_.staticClass, "pack", "(Ljava/util/jar/JarFile;Ljava/io/OutputStream;)V", ref global::java.util.jar.Pack200.Packer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			void java.util.jar.Pack200.Packer.pack(java.util.jar.JarInputStream arg0, java.io.OutputStream arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Pack200.Packer_.staticClass, "pack", "(Ljava/util/jar/JarInputStream;Ljava/io/OutputStream;)V", ref global::java.util.jar.Pack200.Packer_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static Packer_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.jar.Pack200.Packer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Pack200$Packer"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class PackerConstants 
		{
			public static global::java.lang.String SEGMENT_LIMIT
			{
				get
				{
					return "pack.segment.limit";
				}
			}
			public static global::java.lang.String KEEP_FILE_ORDER
			{
				get
				{
					return "pack.keep.file.order";
				}
			}
			public static global::java.lang.String EFFORT
			{
				get
				{
					return "pack.effort";
				}
			}
			public static global::java.lang.String DEFLATE_HINT
			{
				get
				{
					return "pack.deflate.hint";
				}
			}
			public static global::java.lang.String MODIFICATION_TIME
			{
				get
				{
					return "pack.modification.time";
				}
			}
			public static global::java.lang.String PASS_FILE_PFX
			{
				get
				{
					return "pack.pass.file.";
				}
			}
			public static global::java.lang.String UNKNOWN_ATTRIBUTE
			{
				get
				{
					return "pack.unknown.attribute";
				}
			}
			public static global::java.lang.String CLASS_ATTRIBUTE_PFX
			{
				get
				{
					return "pack.class.attribute.";
				}
			}
			public static global::java.lang.String FIELD_ATTRIBUTE_PFX
			{
				get
				{
					return "pack.field.attribute.";
				}
			}
			public static global::java.lang.String METHOD_ATTRIBUTE_PFX
			{
				get
				{
					return "pack.method.attribute.";
				}
			}
			public static global::java.lang.String CODE_ATTRIBUTE_PFX
			{
				get
				{
					return "pack.code.attribute.";
				}
			}
			public static global::java.lang.String PROGRESS
			{
				get
				{
					return "pack.progress";
				}
			}
			public static global::java.lang.String KEEP
			{
				get
				{
					return "keep";
				}
			}
			public static global::java.lang.String PASS
			{
				get
				{
					return "pass";
				}
			}
			public static global::java.lang.String STRIP
			{
				get
				{
					return "strip";
				}
			}
			public static global::java.lang.String ERROR
			{
				get
				{
					return "error";
				}
			}
			public static global::java.lang.String TRUE
			{
				get
				{
					return "true";
				}
			}
			public static global::java.lang.String FALSE
			{
				get
				{
					return "false";
				}
			}
			public static global::java.lang.String LATEST
			{
				get
				{
					return "latest";
				}
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.jar.Pack200.Unpacker_))]
		public partial interface Unpacker  : global::MonoJavaBridge.IJavaObject 
		{
			global::java.util.SortedMap properties();
			void addPropertyChangeListener(java.beans.PropertyChangeListener arg0);
			void removePropertyChangeListener(java.beans.PropertyChangeListener arg0);
			void unpack(java.io.InputStream arg0, java.util.jar.JarOutputStream arg1);
			void unpack(java.io.File arg0, java.util.jar.JarOutputStream arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.jar.Pack200.Unpacker))]
		internal sealed partial class Unpacker_ : java.lang.Object, Unpacker
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Unpacker_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::java.util.SortedMap java.util.jar.Pack200.Unpacker.properties()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.SortedMap>(this, global::java.util.jar.Pack200.Unpacker_.staticClass, "properties", "()Ljava/util/SortedMap;", ref global::java.util.jar.Pack200.Unpacker_._m0) as java.util.SortedMap;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void java.util.jar.Pack200.Unpacker.addPropertyChangeListener(java.beans.PropertyChangeListener arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Pack200.Unpacker_.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", ref global::java.util.jar.Pack200.Unpacker_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void java.util.jar.Pack200.Unpacker.removePropertyChangeListener(java.beans.PropertyChangeListener arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Pack200.Unpacker_.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", ref global::java.util.jar.Pack200.Unpacker_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			void java.util.jar.Pack200.Unpacker.unpack(java.io.InputStream arg0, java.util.jar.JarOutputStream arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Pack200.Unpacker_.staticClass, "unpack", "(Ljava/io/InputStream;Ljava/util/jar/JarOutputStream;)V", ref global::java.util.jar.Pack200.Unpacker_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			void java.util.jar.Pack200.Unpacker.unpack(java.io.File arg0, java.util.jar.JarOutputStream arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.jar.Pack200.Unpacker_.staticClass, "unpack", "(Ljava/io/File;Ljava/util/jar/JarOutputStream;)V", ref global::java.util.jar.Pack200.Unpacker_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static Unpacker_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.jar.Pack200.Unpacker_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Pack200$Unpacker"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class UnpackerConstants 
		{
			public static global::java.lang.String KEEP
			{
				get
				{
					return "keep";
				}
			}
			public static global::java.lang.String TRUE
			{
				get
				{
					return "true";
				}
			}
			public static global::java.lang.String FALSE
			{
				get
				{
					return "false";
				}
			}
			public static global::java.lang.String DEFLATE_HINT
			{
				get
				{
					return "unpack.deflate.hint";
				}
			}
			public static global::java.lang.String PROGRESS
			{
				get
				{
					return "unpack.progress";
				}
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.util.jar.Pack200.Packer newPacker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.Pack200._m0.native == global::System.IntPtr.Zero)
				global::java.util.jar.Pack200._m0 = @__env.GetStaticMethodIDNoThrow(global::java.util.jar.Pack200.staticClass, "newPacker", "()Ljava/util/jar/Pack200$Packer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.jar.Pack200.Packer>(@__env.CallStaticObjectMethod(java.util.jar.Pack200.staticClass, global::java.util.jar.Pack200._m0)) as java.util.jar.Pack200.Packer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.util.jar.Pack200.Unpacker newUnpacker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.jar.Pack200._m1.native == global::System.IntPtr.Zero)
				global::java.util.jar.Pack200._m1 = @__env.GetStaticMethodIDNoThrow(global::java.util.jar.Pack200.staticClass, "newUnpacker", "()Ljava/util/jar/Pack200$Unpacker;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.jar.Pack200.Unpacker>(@__env.CallStaticObjectMethod(java.util.jar.Pack200.staticClass, global::java.util.jar.Pack200._m1)) as java.util.jar.Pack200.Unpacker;
		}
		static Pack200()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Pack200.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Pack200"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.jar.Pack200))]
	internal sealed partial class Pack200_ : java.util.jar.Pack200
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Pack200_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Pack200_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Pack200_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Pack200"));
		}
	}
}
