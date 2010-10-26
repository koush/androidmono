namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Package : java.lang.Object, java.lang.reflect.AnnotatedElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Package()
		{
			InitJNI();
		}
		protected Package(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString20385;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._toString20385)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._toString20385)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20386;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Package._hashCode20386);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._hashCode20386);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName20387;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getName20387)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getName20387)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPackage20388;
		public static global::java.lang.Package getPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Package.staticClass, global::java.lang.Package._getPackage20388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation20389;
		public virtual global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getAnnotation20389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getAnnotation20389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotationPresent20390;
		public virtual bool isAnnotationPresent(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Package._isAnnotationPresent20390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._isAnnotationPresent20390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.annotation.Annotation[] Annotations
		{
			get
			{
				return getAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotations20391;
		public virtual global::java.lang.annotation.Annotation[] getAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getAnnotations20391)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getAnnotations20391)) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations20392;
		public virtual global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getDeclaredAnnotations20392)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getDeclaredAnnotations20392)) as java.lang.annotation.Annotation[];
		}
		public static global::java.lang.Package[] Packages
		{
			get
			{
				return getPackages();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackages20393;
		public static global::java.lang.Package[] getPackages() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Package>(@__env.CallStaticObjectMethod(java.lang.Package.staticClass, global::java.lang.Package._getPackages20393)) as java.lang.Package[];
		}
		internal static global::MonoJavaBridge.MethodId _isSealed20394;
		public virtual bool isSealed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Package._isSealed20394);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._isSealed20394);
		}
		internal static global::MonoJavaBridge.MethodId _isSealed20395;
		public virtual bool isSealed(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Package._isSealed20395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._isSealed20395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SpecificationTitle
		{
			get
			{
				return getSpecificationTitle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpecificationTitle20396;
		public virtual global::java.lang.String getSpecificationTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getSpecificationTitle20396)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationTitle20396)) as java.lang.String;
		}
		public new global::java.lang.String SpecificationVersion
		{
			get
			{
				return getSpecificationVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpecificationVersion20397;
		public virtual global::java.lang.String getSpecificationVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getSpecificationVersion20397)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationVersion20397)) as java.lang.String;
		}
		public new global::java.lang.String SpecificationVendor
		{
			get
			{
				return getSpecificationVendor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpecificationVendor20398;
		public virtual global::java.lang.String getSpecificationVendor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getSpecificationVendor20398)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationVendor20398)) as java.lang.String;
		}
		public new global::java.lang.String ImplementationTitle
		{
			get
			{
				return getImplementationTitle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImplementationTitle20399;
		public virtual global::java.lang.String getImplementationTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getImplementationTitle20399)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationTitle20399)) as java.lang.String;
		}
		public new global::java.lang.String ImplementationVersion
		{
			get
			{
				return getImplementationVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImplementationVersion20400;
		public virtual global::java.lang.String getImplementationVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getImplementationVersion20400)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationVersion20400)) as java.lang.String;
		}
		public new global::java.lang.String ImplementationVendor
		{
			get
			{
				return getImplementationVendor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImplementationVendor20401;
		public virtual global::java.lang.String getImplementationVendor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getImplementationVendor20401)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationVendor20401)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isCompatibleWith20402;
		public virtual bool isCompatibleWith(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Package._isCompatibleWith20402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._isCompatibleWith20402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Package.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Package"));
			global::java.lang.Package._toString20385 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Package._hashCode20386 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "hashCode", "()I");
			global::java.lang.Package._getName20387 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Package._getPackage20388 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Package.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			global::java.lang.Package._getAnnotation20389 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._isAnnotationPresent20390 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			global::java.lang.Package._getAnnotations20391 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._getDeclaredAnnotations20392 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._getPackages20393 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Package.staticClass, "getPackages", "()[Ljava/lang/Package;");
			global::java.lang.Package._isSealed20394 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "isSealed", "()Z");
			global::java.lang.Package._isSealed20395 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "isSealed", "(Ljava/net/URL;)Z");
			global::java.lang.Package._getSpecificationTitle20396 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getSpecificationTitle", "()Ljava/lang/String;");
			global::java.lang.Package._getSpecificationVersion20397 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getSpecificationVersion", "()Ljava/lang/String;");
			global::java.lang.Package._getSpecificationVendor20398 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getSpecificationVendor", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationTitle20399 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getImplementationTitle", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationVersion20400 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getImplementationVersion", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationVendor20401 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getImplementationVendor", "()Ljava/lang/String;");
			global::java.lang.Package._isCompatibleWith20402 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "isCompatibleWith", "(Ljava/lang/String;)Z");
		}
	}
}
