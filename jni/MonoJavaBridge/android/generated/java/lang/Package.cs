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
		internal static global::MonoJavaBridge.MethodId _toString20267;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._toString20267)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._toString20267)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20268;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Package._hashCode20268);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._hashCode20268);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName20269;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getName20269)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getName20269)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPackage20270;
		public static global::java.lang.Package getPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Package.staticClass, global::java.lang.Package._getPackage20270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation20271;
		public virtual global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getAnnotation20271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getAnnotation20271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotationPresent20272;
		public virtual bool isAnnotationPresent(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Package._isAnnotationPresent20272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._isAnnotationPresent20272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.annotation.Annotation[] Annotations
		{
			get
			{
				return getAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotations20273;
		public virtual global::java.lang.annotation.Annotation[] getAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getAnnotations20273)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getAnnotations20273)) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations20274;
		public virtual global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getDeclaredAnnotations20274)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getDeclaredAnnotations20274)) as java.lang.annotation.Annotation[];
		}
		public static global::java.lang.Package[] Packages
		{
			get
			{
				return getPackages();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackages20275;
		public static global::java.lang.Package[] getPackages() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Package>(@__env.CallStaticObjectMethod(java.lang.Package.staticClass, global::java.lang.Package._getPackages20275)) as java.lang.Package[];
		}
		internal static global::MonoJavaBridge.MethodId _isSealed20276;
		public virtual bool isSealed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Package._isSealed20276);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._isSealed20276);
		}
		internal static global::MonoJavaBridge.MethodId _isSealed20277;
		public virtual bool isSealed(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Package._isSealed20277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._isSealed20277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SpecificationTitle
		{
			get
			{
				return getSpecificationTitle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpecificationTitle20278;
		public virtual global::java.lang.String getSpecificationTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getSpecificationTitle20278)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationTitle20278)) as java.lang.String;
		}
		public new global::java.lang.String SpecificationVersion
		{
			get
			{
				return getSpecificationVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpecificationVersion20279;
		public virtual global::java.lang.String getSpecificationVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getSpecificationVersion20279)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationVersion20279)) as java.lang.String;
		}
		public new global::java.lang.String SpecificationVendor
		{
			get
			{
				return getSpecificationVendor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpecificationVendor20280;
		public virtual global::java.lang.String getSpecificationVendor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getSpecificationVendor20280)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationVendor20280)) as java.lang.String;
		}
		public new global::java.lang.String ImplementationTitle
		{
			get
			{
				return getImplementationTitle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImplementationTitle20281;
		public virtual global::java.lang.String getImplementationTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getImplementationTitle20281)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationTitle20281)) as java.lang.String;
		}
		public new global::java.lang.String ImplementationVersion
		{
			get
			{
				return getImplementationVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImplementationVersion20282;
		public virtual global::java.lang.String getImplementationVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getImplementationVersion20282)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationVersion20282)) as java.lang.String;
		}
		public new global::java.lang.String ImplementationVendor
		{
			get
			{
				return getImplementationVendor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImplementationVendor20283;
		public virtual global::java.lang.String getImplementationVendor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Package._getImplementationVendor20283)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationVendor20283)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isCompatibleWith20284;
		public virtual bool isCompatibleWith(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Package._isCompatibleWith20284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Package.staticClass, global::java.lang.Package._isCompatibleWith20284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Package.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Package"));
			global::java.lang.Package._toString20267 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Package._hashCode20268 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "hashCode", "()I");
			global::java.lang.Package._getName20269 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Package._getPackage20270 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Package.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			global::java.lang.Package._getAnnotation20271 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._isAnnotationPresent20272 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			global::java.lang.Package._getAnnotations20273 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._getDeclaredAnnotations20274 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._getPackages20275 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Package.staticClass, "getPackages", "()[Ljava/lang/Package;");
			global::java.lang.Package._isSealed20276 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "isSealed", "()Z");
			global::java.lang.Package._isSealed20277 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "isSealed", "(Ljava/net/URL;)Z");
			global::java.lang.Package._getSpecificationTitle20278 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getSpecificationTitle", "()Ljava/lang/String;");
			global::java.lang.Package._getSpecificationVersion20279 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getSpecificationVersion", "()Ljava/lang/String;");
			global::java.lang.Package._getSpecificationVendor20280 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getSpecificationVendor", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationTitle20281 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getImplementationTitle", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationVersion20282 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getImplementationVersion", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationVendor20283 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "getImplementationVendor", "()Ljava/lang/String;");
			global::java.lang.Package._isCompatibleWith20284 = @__env.GetMethodIDNoThrow(global::java.lang.Package.staticClass, "isCompatibleWith", "(Ljava/lang/String;)Z");
		}
	}
}
