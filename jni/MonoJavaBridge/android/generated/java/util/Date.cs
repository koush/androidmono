namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Date : java.lang.Object, java.io.Serializable, java.lang.Cloneable, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static Date()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.Date), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _equals13646;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Date._equals13646, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Date.staticClass, global::java.util.Date._equals13646, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13647;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Date._toString13647));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Date.staticClass, global::java.util.Date._toString13647));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13648;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._hashCode13648);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._hashCode13648);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone13649;
		public virtual global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Date._clone13649));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Date.staticClass, global::java.util.Date._clone13649));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo13650;
		public virtual int compareTo(java.util.Date arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._compareTo13650, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._compareTo13650, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo13651;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._compareTo13651, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._compareTo13651, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _after13652;
		public virtual bool after(java.util.Date arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Date._after13652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Date.staticClass, global::java.util.Date._after13652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _before13653;
		public virtual bool before(java.util.Date arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Date._before13653, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Date.staticClass, global::java.util.Date._before13653, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse13654;
		public static long parse(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._parse13654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTime13655;
		public virtual void setTime(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Date._setTime13655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setTime13655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTime13656;
		public virtual long getTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.Date._getTime13656);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getTime13656);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getYear13657;
		public virtual int getYear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._getYear13657);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getYear13657);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMonth13658;
		public virtual int getMonth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._getMonth13658);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getMonth13658);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDate13659;
		public virtual int getDate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._getDate13659);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getDate13659);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHours13660;
		public virtual int getHours() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._getHours13660);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getHours13660);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinutes13661;
		public virtual int getMinutes() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._getMinutes13661);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getMinutes13661);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSeconds13662;
		public virtual int getSeconds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._getSeconds13662);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getSeconds13662);
		}
		internal static global::net.sf.jni4net.jni.MethodId _UTC13663;
		public static long UTC(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.util.Date.staticClass, global::java.util.Date._UTC13663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDate13664;
		public virtual void setDate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Date._setDate13664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setDate13664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMonth13665;
		public virtual void setMonth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Date._setMonth13665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setMonth13665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHours13666;
		public virtual void setHours(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Date._setHours13666, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setHours13666, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinutes13667;
		public virtual void setMinutes(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Date._setMinutes13667, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setMinutes13667, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSeconds13668;
		public virtual void setSeconds(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Date._setSeconds13668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setSeconds13668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setYear13669;
		public virtual void setYear(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Date._setYear13669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Date.staticClass, global::java.util.Date._setYear13669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDay13670;
		public virtual int getDay() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._getDay13670);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getDay13670);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toLocaleString13671;
		public virtual global::java.lang.String toLocaleString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Date._toLocaleString13671));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Date.staticClass, global::java.util.Date._toLocaleString13671));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toGMTString13672;
		public virtual global::java.lang.String toGMTString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Date._toGMTString13672));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Date.staticClass, global::java.util.Date._toGMTString13672));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimezoneOffset13673;
		public virtual int getTimezoneOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Date._getTimezoneOffset13673);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Date.staticClass, global::java.util.Date._getTimezoneOffset13673);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Date13674;
		public Date()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date13674, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Date13675;
		public Date(long arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date13675, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Date13676;
		public Date(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date13676, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Date13677;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date13677, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Date13678;
		public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date13678, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Date13679;
		public Date(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Date.staticClass, global::java.util.Date._Date13679, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.Date.staticClass = @__class;
			global::java.util.Date._equals13646 = @__env.GetMethodID(global::java.util.Date.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Date._toString13647 = @__env.GetMethodID(global::java.util.Date.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Date._hashCode13648 = @__env.GetMethodID(global::java.util.Date.staticClass, "hashCode", "()I");
			global::java.util.Date._clone13649 = @__env.GetMethodID(global::java.util.Date.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Date._compareTo13650 = @__env.GetMethodID(global::java.util.Date.staticClass, "compareTo", "(Ljava/util/Date;)I");
			global::java.util.Date._compareTo13651 = @__env.GetMethodID(global::java.util.Date.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.Date._after13652 = @__env.GetMethodID(global::java.util.Date.staticClass, "after", "(Ljava/util/Date;)Z");
			global::java.util.Date._before13653 = @__env.GetMethodID(global::java.util.Date.staticClass, "before", "(Ljava/util/Date;)Z");
			global::java.util.Date._parse13654 = @__env.GetStaticMethodID(global::java.util.Date.staticClass, "parse", "(Ljava/lang/String;)J");
			global::java.util.Date._setTime13655 = @__env.GetMethodID(global::java.util.Date.staticClass, "setTime", "(J)V");
			global::java.util.Date._getTime13656 = @__env.GetMethodID(global::java.util.Date.staticClass, "getTime", "()J");
			global::java.util.Date._getYear13657 = @__env.GetMethodID(global::java.util.Date.staticClass, "getYear", "()I");
			global::java.util.Date._getMonth13658 = @__env.GetMethodID(global::java.util.Date.staticClass, "getMonth", "()I");
			global::java.util.Date._getDate13659 = @__env.GetMethodID(global::java.util.Date.staticClass, "getDate", "()I");
			global::java.util.Date._getHours13660 = @__env.GetMethodID(global::java.util.Date.staticClass, "getHours", "()I");
			global::java.util.Date._getMinutes13661 = @__env.GetMethodID(global::java.util.Date.staticClass, "getMinutes", "()I");
			global::java.util.Date._getSeconds13662 = @__env.GetMethodID(global::java.util.Date.staticClass, "getSeconds", "()I");
			global::java.util.Date._UTC13663 = @__env.GetStaticMethodID(global::java.util.Date.staticClass, "UTC", "(IIIIII)J");
			global::java.util.Date._setDate13664 = @__env.GetMethodID(global::java.util.Date.staticClass, "setDate", "(I)V");
			global::java.util.Date._setMonth13665 = @__env.GetMethodID(global::java.util.Date.staticClass, "setMonth", "(I)V");
			global::java.util.Date._setHours13666 = @__env.GetMethodID(global::java.util.Date.staticClass, "setHours", "(I)V");
			global::java.util.Date._setMinutes13667 = @__env.GetMethodID(global::java.util.Date.staticClass, "setMinutes", "(I)V");
			global::java.util.Date._setSeconds13668 = @__env.GetMethodID(global::java.util.Date.staticClass, "setSeconds", "(I)V");
			global::java.util.Date._setYear13669 = @__env.GetMethodID(global::java.util.Date.staticClass, "setYear", "(I)V");
			global::java.util.Date._getDay13670 = @__env.GetMethodID(global::java.util.Date.staticClass, "getDay", "()I");
			global::java.util.Date._toLocaleString13671 = @__env.GetMethodID(global::java.util.Date.staticClass, "toLocaleString", "()Ljava/lang/String;");
			global::java.util.Date._toGMTString13672 = @__env.GetMethodID(global::java.util.Date.staticClass, "toGMTString", "()Ljava/lang/String;");
			global::java.util.Date._getTimezoneOffset13673 = @__env.GetMethodID(global::java.util.Date.staticClass, "getTimezoneOffset", "()I");
			global::java.util.Date._Date13674 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "()V");
			global::java.util.Date._Date13675 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(J)V");
			global::java.util.Date._Date13676 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(III)V");
			global::java.util.Date._Date13677 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(IIIII)V");
			global::java.util.Date._Date13678 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(IIIIII)V");
			global::java.util.Date._Date13679 = @__env.GetMethodID(global::java.util.Date.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
