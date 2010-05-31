namespace java.lang
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Package : java.lang.Object, java.lang.reflect.AnnotatedElement
	{
		internal static global::java.lang.Class staticClass;
		static Package()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.lang.Package), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.lang.Package(@__env);
			}
		}
		protected Package(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11489;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.Package._hashCode11489);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.Package.staticClass, global::java.lang.Package._hashCode11489);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString11490;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._toString11490));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._toString11490));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName11491;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getName11491));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getName11491));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackage11492;
		public static global::java.lang.Package getPackage(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Package>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Package.staticClass, global::java.lang.Package._getPackage11492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnnotation11493;
		public virtual global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.annotation.Annotation>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getAnnotation11493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.annotation.Annotation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getAnnotation11493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAnnotationPresent11494;
		public virtual bool isAnnotationPresent(java.lang.Class arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Package._isAnnotationPresent11494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Package.staticClass, global::java.lang.Package._isAnnotationPresent11494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnnotations11495;
		public virtual global::java.lang.annotation.Annotation[] getAnnotations() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getAnnotations11495));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getAnnotations11495));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDeclaredAnnotations11496;
		public virtual global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getDeclaredAnnotations11496));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getDeclaredAnnotations11496));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackages11497;
		public static global::java.lang.Package[] getPackages() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Package.staticClass, global::java.lang.Package._getPackages11497));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSealed11498;
		public virtual bool isSealed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Package._isSealed11498);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Package.staticClass, global::java.lang.Package._isSealed11498);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSealed11499;
		public virtual bool isSealed(java.net.URL arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Package._isSealed11499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Package.staticClass, global::java.lang.Package._isSealed11499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCompatibleWith11500;
		public virtual bool isCompatibleWith(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Package._isCompatibleWith11500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Package.staticClass, global::java.lang.Package._isCompatibleWith11500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpecificationTitle11501;
		public virtual global::java.lang.String getSpecificationTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getSpecificationTitle11501));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationTitle11501));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpecificationVersion11502;
		public virtual global::java.lang.String getSpecificationVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getSpecificationVersion11502));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationVersion11502));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpecificationVendor11503;
		public virtual global::java.lang.String getSpecificationVendor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getSpecificationVendor11503));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationVendor11503));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImplementationTitle11504;
		public virtual global::java.lang.String getImplementationTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getImplementationTitle11504));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationTitle11504));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImplementationVersion11505;
		public virtual global::java.lang.String getImplementationVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getImplementationVersion11505));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationVersion11505));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImplementationVendor11506;
		public virtual global::java.lang.String getImplementationVendor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getImplementationVendor11506));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationVendor11506));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.lang.Package.staticClass = @__class;
			global::java.lang.Package._hashCode11489 = @__env.GetMethodID(global::java.lang.Package.staticClass, "hashCode", "()I");
			global::java.lang.Package._toString11490 = @__env.GetMethodID(global::java.lang.Package.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Package._getName11491 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Package._getPackage11492 = @__env.GetStaticMethodID(global::java.lang.Package.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			global::java.lang.Package._getAnnotation11493 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._isAnnotationPresent11494 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			global::java.lang.Package._getAnnotations11495 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._getDeclaredAnnotations11496 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._getPackages11497 = @__env.GetStaticMethodID(global::java.lang.Package.staticClass, "getPackages", "()[Ljava/lang/Package;");
			global::java.lang.Package._isSealed11498 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isSealed", "()Z");
			global::java.lang.Package._isSealed11499 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isSealed", "(Ljava/net/URL;)Z");
			global::java.lang.Package._isCompatibleWith11500 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isCompatibleWith", "(Ljava/lang/String;)Z");
			global::java.lang.Package._getSpecificationTitle11501 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getSpecificationTitle", "()Ljava/lang/String;");
			global::java.lang.Package._getSpecificationVersion11502 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getSpecificationVersion", "()Ljava/lang/String;");
			global::java.lang.Package._getSpecificationVendor11503 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getSpecificationVendor", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationTitle11504 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getImplementationTitle", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationVersion11505 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getImplementationVersion", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationVendor11506 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getImplementationVendor", "()Ljava/lang/String;");
		}
	}
}
