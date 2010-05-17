namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Date : java.lang.Object, java.io.Serializable, java.lang.Cloneable, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Date() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.Date), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.Date(@__env); 
			} 
		} 
		protected Date(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11908; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _hashCode11908); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _hashCode11908); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone11909; 
		public virtual java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone11909)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Date.staticClass, _clone11909)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11910; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallBooleanMethod(this, _equals11910, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Date.staticClass, _equals11910, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11911; 
		public virtual int compareTo(java.util.Date arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _compareTo11911, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _compareTo11911, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11912; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _compareTo11912, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _compareTo11912, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11913; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11913)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Date.staticClass, _toString11913)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _after11914; 
		public virtual bool after(java.util.Date arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallBooleanMethod(this, _after11914, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Date.staticClass, _after11914, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _before11915; 
		public virtual bool before(java.util.Date arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallBooleanMethod(this, _before11915, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Date.staticClass, _before11915, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse11916; 
		public static long parse(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, _parse11916, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTime11917; 
		public virtual void setTime(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setTime11917, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setTime11917, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTime11918; 
		public virtual long getTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallLongMethod(this, _getTime11918); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.Date.staticClass, _getTime11918); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYear11919; 
		public virtual int getYear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getYear11919); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getYear11919); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMonth11920; 
		public virtual int getMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getMonth11920); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getMonth11920); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDate11921; 
		public virtual int getDate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getDate11921); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getDate11921); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHours11922; 
		public virtual int getHours() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getHours11922); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getHours11922); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinutes11923; 
		public virtual int getMinutes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getMinutes11923); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getMinutes11923); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSeconds11924; 
		public virtual int getSeconds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getSeconds11924); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getSeconds11924); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UTC11925; 
		public static long UTC(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, _UTC11925, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDate11926; 
		public virtual void setDate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setDate11926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setDate11926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMonth11927; 
		public virtual void setMonth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setMonth11927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setMonth11927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHours11928; 
		public virtual void setHours(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setHours11928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setHours11928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinutes11929; 
		public virtual void setMinutes(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setMinutes11929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setMinutes11929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSeconds11930; 
		public virtual void setSeconds(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setSeconds11930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setSeconds11930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setYear11931; 
		public virtual void setYear(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setYear11931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setYear11931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDay11932; 
		public virtual int getDay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getDay11932); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getDay11932); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toLocaleString11933; 
		public virtual java.lang.String toLocaleString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toLocaleString11933)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Date.staticClass, _toLocaleString11933)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toGMTString11934; 
		public virtual java.lang.String toGMTString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toGMTString11934)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Date.staticClass, _toGMTString11934)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimezoneOffset11935; 
		public virtual int getTimezoneOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getTimezoneOffset11935); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getTimezoneOffset11935); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date11936; 
		public Date()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date11936, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date11937; 
		public Date(long arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date11937, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date11938; 
		public Date(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date11938, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date11939; 
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date11939, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date11940; 
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date11940, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date11941; 
		public Date(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date11941, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.Date.staticClass = @__class; 
			global::java.util.Date._hashCode11908 = @__env.GetMethodID(global::java.util.Date.staticClass, "hashCode", "()I"); 
			global::java.util.Date._clone11909 = @__env.GetMethodID(global::java.util.Date.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.Date._equals11910 = @__env.GetMethodID(global::java.util.Date.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.Date._compareTo11911 = @__env.GetMethodID(global::java.util.Date.staticClass, "compareTo", "(Ljava/util/Date;)I"); 
			global::java.util.Date._compareTo11912 = @__env.GetMethodID(global::java.util.Date.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.util.Date._toString11913 = @__env.GetMethodID(global::java.util.Date.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.Date._after11914 = @__env.GetMethodID(global::java.util.Date.staticClass, "after", "(Ljava/util/Date;)Z"); 
			global::java.util.Date._before11915 = @__env.GetMethodID(global::java.util.Date.staticClass, "before", "(Ljava/util/Date;)Z"); 
			global::java.util.Date._parse11916 = @__env.GetStaticMethodID(global::java.util.Date.staticClass, "parse", "(Ljava/lang/String;)J"); 
			global::java.util.Date._setTime11917 = @__env.GetMethodID(global::java.util.Date.staticClass, "setTime", "(J)V"); 
			global::java.util.Date._getTime11918 = @__env.GetMethodID(global::java.util.Date.staticClass, "getTime", "()J"); 
			global::java.util.Date._getYear11919 = @__env.GetMethodID(global::java.util.Date.staticClass, "getYear", "()I"); 
			global::java.util.Date._getMonth11920 = @__env.GetMethodID(global::java.util.Date.staticClass, "getMonth", "()I"); 
			global::java.util.Date._getDate11921 = @__env.GetMethodID(global::java.util.Date.staticClass, "getDate", "()I"); 
			global::java.util.Date._getHours11922 = @__env.GetMethodID(global::java.util.Date.staticClass, "getHours", "()I"); 
			global::java.util.Date._getMinutes11923 = @__env.GetMethodID(global::java.util.Date.staticClass, "getMinutes", "()I"); 
			global::java.util.Date._getSeconds11924 = @__env.GetMethodID(global::java.util.Date.staticClass, "getSeconds", "()I"); 
			global::java.util.Date._UTC11925 = @__env.GetStaticMethodID(global::java.util.Date.staticClass, "UTC", "(IIIIII)J"); 
			global::java.util.Date._setDate11926 = @__env.GetMethodID(global::java.util.Date.staticClass, "setDate", "(I)V"); 
			global::java.util.Date._setMonth11927 = @__env.GetMethodID(global::java.util.Date.staticClass, "setMonth", "(I)V"); 
			global::java.util.Date._setHours11928 = @__env.GetMethodID(global::java.util.Date.staticClass, "setHours", "(I)V"); 
			global::java.util.Date._setMinutes11929 = @__env.GetMethodID(global::java.util.Date.staticClass, "setMinutes", "(I)V"); 
			global::java.util.Date._setSeconds11930 = @__env.GetMethodID(global::java.util.Date.staticClass, "setSeconds", "(I)V"); 
			global::java.util.Date._setYear11931 = @__env.GetMethodID(global::java.util.Date.staticClass, "setYear", "(I)V"); 
			global::java.util.Date._getDay11932 = @__env.GetMethodID(global::java.util.Date.staticClass, "getDay", "()I"); 
			global::java.util.Date._toLocaleString11933 = @__env.GetMethodID(global::java.util.Date.staticClass, "toLocaleString", "()Ljava/lang/String;"); 
			global::java.util.Date._toGMTString11934 = @__env.GetMethodID(global::java.util.Date.staticClass, "toGMTString", "()Ljava/lang/String;"); 
			global::java.util.Date._getTimezoneOffset11935 = @__env.GetMethodID(global::java.util.Date.staticClass, "getTimezoneOffset", "()I"); 
			global::java.util.Date._Date11936 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "()V"); 
			global::java.util.Date._Date11937 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(J)V"); 
			global::java.util.Date._Date11938 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(III)V"); 
			global::java.util.Date._Date11939 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(IIIII)V"); 
			global::java.util.Date._Date11940 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(IIIIII)V"); 
			global::java.util.Date._Date11941 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
