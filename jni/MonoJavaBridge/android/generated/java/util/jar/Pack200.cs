namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.jar.Pack200_))]
	public abstract partial class Pack200 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Pack200()
		{
			InitJNI();
		}
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
			static Packer_()
			{
				InitJNI();
			}
			internal Packer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _properties27898;
			global::java.util.SortedMap java.util.jar.Pack200.Packer.properties()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Pack200.Packer_._properties27898)) as java.util.SortedMap;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Pack200.Packer_.staticClass, global::java.util.jar.Pack200.Packer_._properties27898)) as java.util.SortedMap;
			}
			internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener27899;
			void java.util.jar.Pack200.Packer.addPropertyChangeListener(java.beans.PropertyChangeListener arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Packer_._addPropertyChangeListener27899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Packer_.staticClass, global::java.util.jar.Pack200.Packer_._addPropertyChangeListener27899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener27900;
			void java.util.jar.Pack200.Packer.removePropertyChangeListener(java.beans.PropertyChangeListener arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Packer_._removePropertyChangeListener27900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Packer_.staticClass, global::java.util.jar.Pack200.Packer_._removePropertyChangeListener27900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _pack27901;
			void java.util.jar.Pack200.Packer.pack(java.util.jar.JarFile arg0, java.io.OutputStream arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Packer_._pack27901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Packer_.staticClass, global::java.util.jar.Pack200.Packer_._pack27901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _pack27902;
			void java.util.jar.Pack200.Packer.pack(java.util.jar.JarInputStream arg0, java.io.OutputStream arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Packer_._pack27902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Packer_.staticClass, global::java.util.jar.Pack200.Packer_._pack27902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.jar.Pack200.Packer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Pack200$Packer"));
				global::java.util.jar.Pack200.Packer_._properties27898 = @__env.GetMethodIDNoThrow(global::java.util.jar.Pack200.Packer_.staticClass, "properties", "()Ljava/util/SortedMap;");
				global::java.util.jar.Pack200.Packer_._addPropertyChangeListener27899 = @__env.GetMethodIDNoThrow(global::java.util.jar.Pack200.Packer_.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
				global::java.util.jar.Pack200.Packer_._removePropertyChangeListener27900 = @__env.GetMethodIDNoThrow(global::java.util.jar.Pack200.Packer_.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
				global::java.util.jar.Pack200.Packer_._pack27901 = @__env.GetMethodIDNoThrow(global::java.util.jar.Pack200.Packer_.staticClass, "pack", "(Ljava/util/jar/JarFile;Ljava/io/OutputStream;)V");
				global::java.util.jar.Pack200.Packer_._pack27902 = @__env.GetMethodIDNoThrow(global::java.util.jar.Pack200.Packer_.staticClass, "pack", "(Ljava/util/jar/JarInputStream;Ljava/io/OutputStream;)V");
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
			static Unpacker_()
			{
				InitJNI();
			}
			internal Unpacker_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _properties27922;
			global::java.util.SortedMap java.util.jar.Pack200.Unpacker.properties()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Pack200.Unpacker_._properties27922)) as java.util.SortedMap;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Pack200.Unpacker_.staticClass, global::java.util.jar.Pack200.Unpacker_._properties27922)) as java.util.SortedMap;
			}
			internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener27923;
			void java.util.jar.Pack200.Unpacker.addPropertyChangeListener(java.beans.PropertyChangeListener arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Unpacker_._addPropertyChangeListener27923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Unpacker_.staticClass, global::java.util.jar.Pack200.Unpacker_._addPropertyChangeListener27923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener27924;
			void java.util.jar.Pack200.Unpacker.removePropertyChangeListener(java.beans.PropertyChangeListener arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Unpacker_._removePropertyChangeListener27924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Unpacker_.staticClass, global::java.util.jar.Pack200.Unpacker_._removePropertyChangeListener27924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _unpack27925;
			void java.util.jar.Pack200.Unpacker.unpack(java.io.InputStream arg0, java.util.jar.JarOutputStream arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Unpacker_._unpack27925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Unpacker_.staticClass, global::java.util.jar.Pack200.Unpacker_._unpack27925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _unpack27926;
			void java.util.jar.Pack200.Unpacker.unpack(java.io.File arg0, java.util.jar.JarOutputStream arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Unpacker_._unpack27926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Pack200.Unpacker_.staticClass, global::java.util.jar.Pack200.Unpacker_._unpack27926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.jar.Pack200.Unpacker_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Pack200$Unpacker"));
				global::java.util.jar.Pack200.Unpacker_._properties27922 = @__env.GetMethodIDNoThrow(global::java.util.jar.Pack200.Unpacker_.staticClass, "properties", "()Ljava/util/SortedMap;");
				global::java.util.jar.Pack200.Unpacker_._addPropertyChangeListener27923 = @__env.GetMethodIDNoThrow(global::java.util.jar.Pack200.Unpacker_.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
				global::java.util.jar.Pack200.Unpacker_._removePropertyChangeListener27924 = @__env.GetMethodIDNoThrow(global::java.util.jar.Pack200.Unpacker_.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
				global::java.util.jar.Pack200.Unpacker_._unpack27925 = @__env.GetMethodIDNoThrow(global::java.util.jar.Pack200.Unpacker_.staticClass, "unpack", "(Ljava/io/InputStream;Ljava/util/jar/JarOutputStream;)V");
				global::java.util.jar.Pack200.Unpacker_._unpack27926 = @__env.GetMethodIDNoThrow(global::java.util.jar.Pack200.Unpacker_.staticClass, "unpack", "(Ljava/io/File;Ljava/util/jar/JarOutputStream;)V");
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
		internal static global::MonoJavaBridge.MethodId _newPacker27932;
		public static global::java.util.jar.Pack200.Packer newPacker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.jar.Pack200.Packer>(@__env.CallStaticObjectMethod(java.util.jar.Pack200.staticClass, global::java.util.jar.Pack200._newPacker27932)) as java.util.jar.Pack200.Packer;
		}
		internal static global::MonoJavaBridge.MethodId _newUnpacker27933;
		public static global::java.util.jar.Pack200.Unpacker newUnpacker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.jar.Pack200.Unpacker>(@__env.CallStaticObjectMethod(java.util.jar.Pack200.staticClass, global::java.util.jar.Pack200._newUnpacker27933)) as java.util.jar.Pack200.Unpacker;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Pack200.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Pack200"));
			global::java.util.jar.Pack200._newPacker27932 = @__env.GetStaticMethodIDNoThrow(global::java.util.jar.Pack200.staticClass, "newPacker", "()Ljava/util/jar/Pack200$Packer;");
			global::java.util.jar.Pack200._newUnpacker27933 = @__env.GetStaticMethodIDNoThrow(global::java.util.jar.Pack200.staticClass, "newUnpacker", "()Ljava/util/jar/Pack200$Unpacker;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.jar.Pack200))]
	internal sealed partial class Pack200_ : java.util.jar.Pack200
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Pack200_()
		{
			InitJNI();
		}
		internal Pack200_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Pack200_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Pack200"));
		}
	}
}
