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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12818; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _hashCode12818); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _hashCode12818); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone12819; 
		public virtual java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone12819)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Date.staticClass, _clone12819)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12820; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallBooleanMethod(this, _equals12820, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Date.staticClass, _equals12820, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12821; 
		public virtual int compareTo(java.util.Date arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _compareTo12821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _compareTo12821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12822; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _compareTo12822, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _compareTo12822, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12823; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12823)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Date.staticClass, _toString12823)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _after12824; 
		public virtual bool after(java.util.Date arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallBooleanMethod(this, _after12824, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Date.staticClass, _after12824, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _before12825; 
		public virtual bool before(java.util.Date arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallBooleanMethod(this, _before12825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Date.staticClass, _before12825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse12826; 
		public static long parse(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, _parse12826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTime12827; 
		public virtual void setTime(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setTime12827, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setTime12827, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTime12828; 
		public virtual long getTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallLongMethod(this, _getTime12828); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.Date.staticClass, _getTime12828); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYear12829; 
		public virtual int getYear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getYear12829); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getYear12829); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMonth12830; 
		public virtual int getMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getMonth12830); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getMonth12830); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDate12831; 
		public virtual int getDate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getDate12831); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getDate12831); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHours12832; 
		public virtual int getHours() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getHours12832); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getHours12832); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinutes12833; 
		public virtual int getMinutes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getMinutes12833); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getMinutes12833); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSeconds12834; 
		public virtual int getSeconds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getSeconds12834); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getSeconds12834); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UTC12835; 
		public static long UTC(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, _UTC12835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDate12836; 
		public virtual void setDate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setDate12836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setDate12836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMonth12837; 
		public virtual void setMonth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setMonth12837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setMonth12837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHours12838; 
		public virtual void setHours(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setHours12838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setHours12838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinutes12839; 
		public virtual void setMinutes(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setMinutes12839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setMinutes12839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSeconds12840; 
		public virtual void setSeconds(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setSeconds12840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setSeconds12840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setYear12841; 
		public virtual void setYear(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				@__env.CallVoidMethod(this, _setYear12841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Date.staticClass, _setYear12841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDay12842; 
		public virtual int getDay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getDay12842); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getDay12842); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toLocaleString12843; 
		public virtual java.lang.String toLocaleString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toLocaleString12843)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Date.staticClass, _toLocaleString12843)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toGMTString12844; 
		public virtual java.lang.String toGMTString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toGMTString12844)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Date.staticClass, _toGMTString12844)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimezoneOffset12845; 
		public virtual int getTimezoneOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Date)) 
				return @__env.CallIntMethod(this, _getTimezoneOffset12845); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Date.staticClass, _getTimezoneOffset12845); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date12846; 
		public Date()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date12846, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date12847; 
		public Date(long arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date12847, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date12848; 
		public Date(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date12848, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date12849; 
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date12849, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date12850; 
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date12850, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Date12851; 
		public Date(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Date.staticClass, _Date12851, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.Date.staticClass = @__class; 
			global::java.util.Date._hashCode12818 = @__env.GetMethodID(global::java.util.Date.staticClass, "hashCode", "()I"); 
			global::java.util.Date._clone12819 = @__env.GetMethodID(global::java.util.Date.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.Date._equals12820 = @__env.GetMethodID(global::java.util.Date.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.Date._compareTo12821 = @__env.GetMethodID(global::java.util.Date.staticClass, "compareTo", "(Ljava/util/Date;)I"); 
			global::java.util.Date._compareTo12822 = @__env.GetMethodID(global::java.util.Date.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.util.Date._toString12823 = @__env.GetMethodID(global::java.util.Date.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.Date._after12824 = @__env.GetMethodID(global::java.util.Date.staticClass, "after", "(Ljava/util/Date;)Z"); 
			global::java.util.Date._before12825 = @__env.GetMethodID(global::java.util.Date.staticClass, "before", "(Ljava/util/Date;)Z"); 
			global::java.util.Date._parse12826 = @__env.GetStaticMethodID(global::java.util.Date.staticClass, "parse", "(Ljava/lang/String;)J"); 
			global::java.util.Date._setTime12827 = @__env.GetMethodID(global::java.util.Date.staticClass, "setTime", "(J)V"); 
			global::java.util.Date._getTime12828 = @__env.GetMethodID(global::java.util.Date.staticClass, "getTime", "()J"); 
			global::java.util.Date._getYear12829 = @__env.GetMethodID(global::java.util.Date.staticClass, "getYear", "()I"); 
			global::java.util.Date._getMonth12830 = @__env.GetMethodID(global::java.util.Date.staticClass, "getMonth", "()I"); 
			global::java.util.Date._getDate12831 = @__env.GetMethodID(global::java.util.Date.staticClass, "getDate", "()I"); 
			global::java.util.Date._getHours12832 = @__env.GetMethodID(global::java.util.Date.staticClass, "getHours", "()I"); 
			global::java.util.Date._getMinutes12833 = @__env.GetMethodID(global::java.util.Date.staticClass, "getMinutes", "()I"); 
			global::java.util.Date._getSeconds12834 = @__env.GetMethodID(global::java.util.Date.staticClass, "getSeconds", "()I"); 
			global::java.util.Date._UTC12835 = @__env.GetStaticMethodID(global::java.util.Date.staticClass, "UTC", "(IIIIII)J"); 
			global::java.util.Date._setDate12836 = @__env.GetMethodID(global::java.util.Date.staticClass, "setDate", "(I)V"); 
			global::java.util.Date._setMonth12837 = @__env.GetMethodID(global::java.util.Date.staticClass, "setMonth", "(I)V"); 
			global::java.util.Date._setHours12838 = @__env.GetMethodID(global::java.util.Date.staticClass, "setHours", "(I)V"); 
			global::java.util.Date._setMinutes12839 = @__env.GetMethodID(global::java.util.Date.staticClass, "setMinutes", "(I)V"); 
			global::java.util.Date._setSeconds12840 = @__env.GetMethodID(global::java.util.Date.staticClass, "setSeconds", "(I)V"); 
			global::java.util.Date._setYear12841 = @__env.GetMethodID(global::java.util.Date.staticClass, "setYear", "(I)V"); 
			global::java.util.Date._getDay12842 = @__env.GetMethodID(global::java.util.Date.staticClass, "getDay", "()I"); 
			global::java.util.Date._toLocaleString12843 = @__env.GetMethodID(global::java.util.Date.staticClass, "toLocaleString", "()Ljava/lang/String;"); 
			global::java.util.Date._toGMTString12844 = @__env.GetMethodID(global::java.util.Date.staticClass, "toGMTString", "()Ljava/lang/String;"); 
			global::java.util.Date._getTimezoneOffset12845 = @__env.GetMethodID(global::java.util.Date.staticClass, "getTimezoneOffset", "()I"); 
			global::java.util.Date._Date12846 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "()V"); 
			global::java.util.Date._Date12847 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(J)V"); 
			global::java.util.Date._Date12848 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(III)V"); 
			global::java.util.Date._Date12849 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(IIIII)V"); 
			global::java.util.Date._Date12850 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(IIIIII)V"); 
			global::java.util.Date._Date12851 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
