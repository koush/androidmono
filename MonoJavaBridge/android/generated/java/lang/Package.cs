namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Package : java.lang.Object, java.lang.reflect.AnnotatedElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Package(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Package.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Package._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Package.staticClass, "hashCode", "()I", ref global::java.lang.Package._m1);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Package.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.Package._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.Package getPackage(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Package._m3.native == global::System.IntPtr.Zero)
				global::java.lang.Package._m3 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Package.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Package.staticClass, global::java.lang.Package._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.Package.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", ref global::java.lang.Package._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.annotation.Annotation;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isAnnotationPresent(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Package.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z", ref global::java.lang.Package._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.annotation.Annotation[] Annotations
		{
			get
			{
				return getAnnotations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.annotation.Annotation[] getAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.Package.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.Package._m6) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.Package.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.Package._m7) as java.lang.annotation.Annotation[];
		}
		public static global::java.lang.Package[] Packages
		{
			get
			{
				return getPackages();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.Package[] getPackages()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Package._m8.native == global::System.IntPtr.Zero)
				global::java.lang.Package._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Package.staticClass, "getPackages", "()[Ljava/lang/Package;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Package>(@__env.CallStaticObjectMethod(java.lang.Package.staticClass, global::java.lang.Package._m8)) as java.lang.Package[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isSealed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Package.staticClass, "isSealed", "()Z", ref global::java.lang.Package._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isSealed(java.net.URL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Package.staticClass, "isSealed", "(Ljava/net/URL;)Z", ref global::java.lang.Package._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SpecificationTitle
		{
			get
			{
				return getSpecificationTitle();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String getSpecificationTitle()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Package.staticClass, "getSpecificationTitle", "()Ljava/lang/String;", ref global::java.lang.Package._m11) as java.lang.String;
		}
		public new global::java.lang.String SpecificationVersion
		{
			get
			{
				return getSpecificationVersion();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.String getSpecificationVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Package.staticClass, "getSpecificationVersion", "()Ljava/lang/String;", ref global::java.lang.Package._m12) as java.lang.String;
		}
		public new global::java.lang.String SpecificationVendor
		{
			get
			{
				return getSpecificationVendor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String getSpecificationVendor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Package.staticClass, "getSpecificationVendor", "()Ljava/lang/String;", ref global::java.lang.Package._m13) as java.lang.String;
		}
		public new global::java.lang.String ImplementationTitle
		{
			get
			{
				return getImplementationTitle();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.String getImplementationTitle()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Package.staticClass, "getImplementationTitle", "()Ljava/lang/String;", ref global::java.lang.Package._m14) as java.lang.String;
		}
		public new global::java.lang.String ImplementationVersion
		{
			get
			{
				return getImplementationVersion();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.lang.String getImplementationVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Package.staticClass, "getImplementationVersion", "()Ljava/lang/String;", ref global::java.lang.Package._m15) as java.lang.String;
		}
		public new global::java.lang.String ImplementationVendor
		{
			get
			{
				return getImplementationVendor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.String getImplementationVendor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Package.staticClass, "getImplementationVendor", "()Ljava/lang/String;", ref global::java.lang.Package._m16) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool isCompatibleWith(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Package.staticClass, "isCompatibleWith", "(Ljava/lang/String;)Z", ref global::java.lang.Package._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Package()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Package.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Package"));
		}
		internal static void InitJNI()
		{
		}
	}
}
