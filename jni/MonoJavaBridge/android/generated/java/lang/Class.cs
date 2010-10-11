namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Class : java.lang.Object, java.io.Serializable, java.lang.reflect.GenericDeclaration, java.lang.reflect.Type, java.lang.reflect.AnnotatedElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Class()
		{
			InitJNI();
		}
		internal Class(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _forName12827;
		public static global::java.lang.Class forName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Class.staticClass, global::java.lang.Class._forName12827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _forName12828;
		public static global::java.lang.Class forName(java.lang.String arg0, bool arg1, java.lang.ClassLoader arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Class.staticClass, global::java.lang.Class._forName12828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _toString12829;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._toString12829)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._toString12829)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAssignableFrom12830;
		public bool isAssignableFrom(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAssignableFrom12830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAssignableFrom12830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInstance12831;
		public bool isInstance(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isInstance12831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isInstance12831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers12832;
		public int getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Class._getModifiers12832);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getModifiers12832);
		}
		internal static global::MonoJavaBridge.MethodId _isInterface12833;
		public bool isInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isInterface12833);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isInterface12833);
		}
		internal static global::MonoJavaBridge.MethodId _isArray12834;
		public bool isArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isArray12834);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isArray12834);
		}
		internal static global::MonoJavaBridge.MethodId _isPrimitive12835;
		public bool isPrimitive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isPrimitive12835);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isPrimitive12835);
		}
		internal static global::MonoJavaBridge.MethodId _getSuperclass12836;
		public global::java.lang.Class getSuperclass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getSuperclass12836)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getSuperclass12836)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getComponentType12837;
		public global::java.lang.Class getComponentType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getComponentType12837)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getComponentType12837)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getName12838;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getName12838)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getName12838)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance12839;
		public global::java.lang.Object newInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._newInstance12839)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._newInstance12839)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotation12840;
		public bool isAnnotation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAnnotation12840);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAnnotation12840);
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic12841;
		public bool isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isSynthetic12841);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isSynthetic12841);
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader12842;
		public global::java.lang.ClassLoader getClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getClassLoader12842)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getClassLoader12842)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters12843;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getTypeParameters12843)) as java.lang.reflect.TypeVariable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getTypeParameters12843)) as java.lang.reflect.TypeVariable[];
		}
		internal static global::MonoJavaBridge.MethodId _getGenericSuperclass12844;
		public global::java.lang.reflect.Type getGenericSuperclass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getGenericSuperclass12844)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getGenericSuperclass12844)) as java.lang.reflect.Type;
		}
		internal static global::MonoJavaBridge.MethodId _getPackage12845;
		public global::java.lang.Package getPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getPackage12845)) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getPackage12845)) as java.lang.Package;
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaces12846;
		public global::java.lang.Class[] getInterfaces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getInterfaces12846)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getInterfaces12846)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _getGenericInterfaces12847;
		public global::java.lang.reflect.Type[] getGenericInterfaces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getGenericInterfaces12847)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getGenericInterfaces12847)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _getSigners12848;
		public global::java.lang.Object[] getSigners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getSigners12848)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getSigners12848)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingMethod12849;
		public global::java.lang.reflect.Method getEnclosingMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnclosingMethod12849)) as java.lang.reflect.Method;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnclosingMethod12849)) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingConstructor12850;
		public global::java.lang.reflect.Constructor getEnclosingConstructor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnclosingConstructor12850)) as java.lang.reflect.Constructor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnclosingConstructor12850)) as java.lang.reflect.Constructor;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass12851;
		public global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaringClass12851)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaringClass12851)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingClass12852;
		public global::java.lang.Class getEnclosingClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnclosingClass12852)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnclosingClass12852)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getSimpleName12853;
		public global::java.lang.String getSimpleName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getSimpleName12853)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getSimpleName12853)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalName12854;
		public global::java.lang.String getCanonicalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getCanonicalName12854)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getCanonicalName12854)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAnonymousClass12855;
		public bool isAnonymousClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAnonymousClass12855);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAnonymousClass12855);
		}
		internal static global::MonoJavaBridge.MethodId _isLocalClass12856;
		public bool isLocalClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isLocalClass12856);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isLocalClass12856);
		}
		internal static global::MonoJavaBridge.MethodId _isMemberClass12857;
		public bool isMemberClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isMemberClass12857);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isMemberClass12857);
		}
		internal static global::MonoJavaBridge.MethodId _getClasses12858;
		public global::java.lang.Class[] getClasses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getClasses12858)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getClasses12858)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _getFields12859;
		public global::java.lang.reflect.Field[] getFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getFields12859)) as java.lang.reflect.Field[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getFields12859)) as java.lang.reflect.Field[];
		}
		internal static global::MonoJavaBridge.MethodId _getMethods12860;
		public global::java.lang.reflect.Method[] getMethods() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getMethods12860)) as java.lang.reflect.Method[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getMethods12860)) as java.lang.reflect.Method[];
		}
		internal static global::MonoJavaBridge.MethodId _getConstructors12861;
		public global::java.lang.reflect.Constructor[] getConstructors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getConstructors12861)) as java.lang.reflect.Constructor[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getConstructors12861)) as java.lang.reflect.Constructor[];
		}
		internal static global::MonoJavaBridge.MethodId _getField12862;
		public global::java.lang.reflect.Field getField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getField12862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getField12862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
		}
		internal static global::MonoJavaBridge.MethodId _getMethod12863;
		public global::java.lang.reflect.Method getMethod(java.lang.String arg0, java.lang.Class[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getMethod12863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getMethod12863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _getConstructor12864;
		public global::java.lang.reflect.Constructor getConstructor(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getConstructor12864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getConstructor12864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredClasses12865;
		public global::java.lang.Class[] getDeclaredClasses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredClasses12865)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredClasses12865)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredFields12866;
		public global::java.lang.reflect.Field[] getDeclaredFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredFields12866)) as java.lang.reflect.Field[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredFields12866)) as java.lang.reflect.Field[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredMethods12867;
		public global::java.lang.reflect.Method[] getDeclaredMethods() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredMethods12867)) as java.lang.reflect.Method[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredMethods12867)) as java.lang.reflect.Method[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredConstructors12868;
		public global::java.lang.reflect.Constructor[] getDeclaredConstructors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredConstructors12868)) as java.lang.reflect.Constructor[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredConstructors12868)) as java.lang.reflect.Constructor[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredField12869;
		public global::java.lang.reflect.Field getDeclaredField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredField12869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredField12869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredMethod12870;
		public global::java.lang.reflect.Method getDeclaredMethod(java.lang.String arg0, java.lang.Class[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredMethod12870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredMethod12870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredConstructor12871;
		public global::java.lang.reflect.Constructor getDeclaredConstructor(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredConstructor12871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredConstructor12871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceAsStream12872;
		public global::java.io.InputStream getResourceAsStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getResourceAsStream12872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getResourceAsStream12872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getResource12873;
		public global::java.net.URL getResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getResource12873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getResource12873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getProtectionDomain12874;
		public global::java.security.ProtectionDomain getProtectionDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getProtectionDomain12874)) as java.security.ProtectionDomain;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getProtectionDomain12874)) as java.security.ProtectionDomain;
		}
		internal static global::MonoJavaBridge.MethodId _desiredAssertionStatus12875;
		public bool desiredAssertionStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._desiredAssertionStatus12875);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._desiredAssertionStatus12875);
		}
		internal static global::MonoJavaBridge.MethodId _isEnum12876;
		public bool isEnum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isEnum12876);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isEnum12876);
		}
		internal static global::MonoJavaBridge.MethodId _getEnumConstants12877;
		public global::java.lang.Object[] getEnumConstants() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnumConstants12877)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnumConstants12877)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _cast12878;
		public global::java.lang.Object cast(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._cast12878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._cast12878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _asSubclass12879;
		public global::java.lang.Class asSubclass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._asSubclass12879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._asSubclass12879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation12880;
		public global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getAnnotation12880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getAnnotation12880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotationPresent12881;
		public bool isAnnotationPresent(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAnnotationPresent12881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAnnotationPresent12881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotations12882;
		public global::java.lang.annotation.Annotation[] getAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getAnnotations12882)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getAnnotations12882)) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations12883;
		public global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredAnnotations12883)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredAnnotations12883)) as java.lang.annotation.Annotation[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Class.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Class"));
			global::java.lang.Class._forName12827 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.Class._forName12828 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;");
			global::java.lang.Class._toString12829 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Class._isAssignableFrom12830 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAssignableFrom", "(Ljava/lang/Class;)Z");
			global::java.lang.Class._isInstance12831 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isInstance", "(Ljava/lang/Object;)Z");
			global::java.lang.Class._getModifiers12832 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getModifiers", "()I");
			global::java.lang.Class._isInterface12833 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isInterface", "()Z");
			global::java.lang.Class._isArray12834 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isArray", "()Z");
			global::java.lang.Class._isPrimitive12835 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isPrimitive", "()Z");
			global::java.lang.Class._getSuperclass12836 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getSuperclass", "()Ljava/lang/Class;");
			global::java.lang.Class._getComponentType12837 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getComponentType", "()Ljava/lang/Class;");
			global::java.lang.Class._getName12838 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Class._newInstance12839 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "newInstance", "()Ljava/lang/Object;");
			global::java.lang.Class._isAnnotation12840 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAnnotation", "()Z");
			global::java.lang.Class._isSynthetic12841 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isSynthetic", "()Z");
			global::java.lang.Class._getClassLoader12842 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.Class._getTypeParameters12843 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			global::java.lang.Class._getGenericSuperclass12844 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getGenericSuperclass", "()Ljava/lang/reflect/Type;");
			global::java.lang.Class._getPackage12845 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getPackage", "()Ljava/lang/Package;");
			global::java.lang.Class._getInterfaces12846 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getInterfaces", "()[Ljava/lang/Class;");
			global::java.lang.Class._getGenericInterfaces12847 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getGenericInterfaces", "()[Ljava/lang/reflect/Type;");
			global::java.lang.Class._getSigners12848 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getSigners", "()[Ljava/lang/Object;");
			global::java.lang.Class._getEnclosingMethod12849 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnclosingMethod", "()Ljava/lang/reflect/Method;");
			global::java.lang.Class._getEnclosingConstructor12850 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getDeclaringClass12851 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.Class._getEnclosingClass12852 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnclosingClass", "()Ljava/lang/Class;");
			global::java.lang.Class._getSimpleName12853 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getSimpleName", "()Ljava/lang/String;");
			global::java.lang.Class._getCanonicalName12854 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getCanonicalName", "()Ljava/lang/String;");
			global::java.lang.Class._isAnonymousClass12855 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAnonymousClass", "()Z");
			global::java.lang.Class._isLocalClass12856 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isLocalClass", "()Z");
			global::java.lang.Class._isMemberClass12857 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isMemberClass", "()Z");
			global::java.lang.Class._getClasses12858 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getClasses", "()[Ljava/lang/Class;");
			global::java.lang.Class._getFields12859 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getFields", "()[Ljava/lang/reflect/Field;");
			global::java.lang.Class._getMethods12860 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getMethods", "()[Ljava/lang/reflect/Method;");
			global::java.lang.Class._getConstructors12861 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getConstructors", "()[Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getField12862 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
			global::java.lang.Class._getMethod12863 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			global::java.lang.Class._getConstructor12864 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getDeclaredClasses12865 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredClasses", "()[Ljava/lang/Class;");
			global::java.lang.Class._getDeclaredFields12866 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredFields", "()[Ljava/lang/reflect/Field;");
			global::java.lang.Class._getDeclaredMethods12867 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredMethods", "()[Ljava/lang/reflect/Method;");
			global::java.lang.Class._getDeclaredConstructors12868 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getDeclaredField12869 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
			global::java.lang.Class._getDeclaredMethod12870 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			global::java.lang.Class._getDeclaredConstructor12871 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getResourceAsStream12872 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.Class._getResource12873 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.Class._getProtectionDomain12874 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getProtectionDomain", "()Ljava/security/ProtectionDomain;");
			global::java.lang.Class._desiredAssertionStatus12875 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "desiredAssertionStatus", "()Z");
			global::java.lang.Class._isEnum12876 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isEnum", "()Z");
			global::java.lang.Class._getEnumConstants12877 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnumConstants", "()[Ljava/lang/Object;");
			global::java.lang.Class._cast12878 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "cast", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.Class._asSubclass12879 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;");
			global::java.lang.Class._getAnnotation12880 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.Class._isAnnotationPresent12881 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			global::java.lang.Class._getAnnotations12882 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Class._getDeclaredAnnotations12883 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
		}
	}
}
