namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Location : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Location() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.location.Location), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.location.Location(@__env); 
			} 
		} 
		protected Location(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4049; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4049)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Location.staticClass, _toString4049)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set4050; 
		public virtual void set(android.location.Location arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _set4050, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _set4050, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset4051; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _reset4051); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _reset4051); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTime4052; 
		public virtual void setTime(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _setTime4052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _setTime4052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTime4053; 
		public virtual long getTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallLongMethod(this, _getTime4053); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.location.Location.staticClass, _getTime4053); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProvider4054; 
		public virtual java.lang.String getProvider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getProvider4054)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Location.staticClass, _getProvider4054)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convert4055; 
		public static double convert(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticDoubleMethod(android.location.Location.staticClass, _convert4055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convert4056; 
		public static java.lang.String convert(double arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.location.Location.staticClass, _convert4056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump4057; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _dump4057, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _dump4057, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4058; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _writeToParcel4058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _writeToParcel4058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4059; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallIntMethod(this, _describeContents4059); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.location.Location.staticClass, _describeContents4059); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras4060; 
		public virtual android.os.Bundle getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getExtras4060)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Location.staticClass, _getExtras4060)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLatitude4061; 
		public virtual double getLatitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallDoubleMethod(this, _getLatitude4061); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.location.Location.staticClass, _getLatitude4061); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLatitude4062; 
		public virtual void setLatitude(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _setLatitude4062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _setLatitude4062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLongitude4063; 
		public virtual double getLongitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallDoubleMethod(this, _getLongitude4063); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.location.Location.staticClass, _getLongitude4063); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLongitude4064; 
		public virtual void setLongitude(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _setLongitude4064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _setLongitude4064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtras4065; 
		public virtual void setExtras(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _setExtras4065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _setExtras4065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAccuracy4066; 
		public virtual void setAccuracy(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _setAccuracy4066, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _setAccuracy4066, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAccuracy4067; 
		public virtual float getAccuracy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallFloatMethod(this, _getAccuracy4067); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.location.Location.staticClass, _getAccuracy4067); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _distanceBetween4068; 
		public static void distanceBetween(double arg0, double arg1, double arg2, double arg3, float[] arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.location.Location.staticClass, _distanceBetween4068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _distanceTo4069; 
		public virtual float distanceTo(android.location.Location arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallFloatMethod(this, _distanceTo4069, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.location.Location.staticClass, _distanceTo4069, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bearingTo4070; 
		public virtual float bearingTo(android.location.Location arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallFloatMethod(this, _bearingTo4070, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.location.Location.staticClass, _bearingTo4070, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProvider4071; 
		public virtual void setProvider(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _setProvider4071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _setProvider4071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAltitude4072; 
		public virtual bool hasAltitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallBooleanMethod(this, _hasAltitude4072); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.Location.staticClass, _hasAltitude4072); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAltitude4073; 
		public virtual double getAltitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallDoubleMethod(this, _getAltitude4073); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.location.Location.staticClass, _getAltitude4073); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAltitude4074; 
		public virtual void setAltitude(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _setAltitude4074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _setAltitude4074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAltitude4075; 
		public virtual void removeAltitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _removeAltitude4075); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _removeAltitude4075); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasSpeed4076; 
		public virtual bool hasSpeed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallBooleanMethod(this, _hasSpeed4076); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.Location.staticClass, _hasSpeed4076); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpeed4077; 
		public virtual float getSpeed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallFloatMethod(this, _getSpeed4077); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.location.Location.staticClass, _getSpeed4077); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpeed4078; 
		public virtual void setSpeed(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _setSpeed4078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _setSpeed4078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeSpeed4079; 
		public virtual void removeSpeed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _removeSpeed4079); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _removeSpeed4079); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasBearing4080; 
		public virtual bool hasBearing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallBooleanMethod(this, _hasBearing4080); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.Location.staticClass, _hasBearing4080); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBearing4081; 
		public virtual float getBearing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallFloatMethod(this, _getBearing4081); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.location.Location.staticClass, _getBearing4081); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBearing4082; 
		public virtual void setBearing(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _setBearing4082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _setBearing4082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeBearing4083; 
		public virtual void removeBearing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _removeBearing4083); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _removeBearing4083); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAccuracy4084; 
		public virtual bool hasAccuracy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallBooleanMethod(this, _hasAccuracy4084); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.Location.staticClass, _hasAccuracy4084); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAccuracy4085; 
		public virtual void removeAccuracy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, _removeAccuracy4085); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Location.staticClass, _removeAccuracy4085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Location4086; 
		public Location(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.location.Location.staticClass, _Location4086, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Location4087; 
		public Location(android.location.Location arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.location.Location.staticClass, _Location4087, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int FORMAT_DEGREES
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int FORMAT_MINUTES
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int FORMAT_SECONDS
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4088; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.Location.staticClass = @__class; 
			global::android.location.Location._toString4049 = @__env.GetMethodID(global::android.location.Location.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.location.Location._set4050 = @__env.GetMethodID(global::android.location.Location.staticClass, "set", "(Landroid/location/Location;)V"); 
			global::android.location.Location._reset4051 = @__env.GetMethodID(global::android.location.Location.staticClass, "reset", "()V"); 
			global::android.location.Location._setTime4052 = @__env.GetMethodID(global::android.location.Location.staticClass, "setTime", "(J)V"); 
			global::android.location.Location._getTime4053 = @__env.GetMethodID(global::android.location.Location.staticClass, "getTime", "()J"); 
			global::android.location.Location._getProvider4054 = @__env.GetMethodID(global::android.location.Location.staticClass, "getProvider", "()Ljava/lang/String;"); 
			global::android.location.Location._convert4055 = @__env.GetStaticMethodID(global::android.location.Location.staticClass, "convert", "(Ljava/lang/String;)D"); 
			global::android.location.Location._convert4056 = @__env.GetStaticMethodID(global::android.location.Location.staticClass, "convert", "(DI)Ljava/lang/String;"); 
			global::android.location.Location._dump4057 = @__env.GetMethodID(global::android.location.Location.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.location.Location._writeToParcel4058 = @__env.GetMethodID(global::android.location.Location.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.location.Location._describeContents4059 = @__env.GetMethodID(global::android.location.Location.staticClass, "describeContents", "()I"); 
			global::android.location.Location._getExtras4060 = @__env.GetMethodID(global::android.location.Location.staticClass, "getExtras", "()Landroid/os/Bundle;"); 
			global::android.location.Location._getLatitude4061 = @__env.GetMethodID(global::android.location.Location.staticClass, "getLatitude", "()D"); 
			global::android.location.Location._setLatitude4062 = @__env.GetMethodID(global::android.location.Location.staticClass, "setLatitude", "(D)V"); 
			global::android.location.Location._getLongitude4063 = @__env.GetMethodID(global::android.location.Location.staticClass, "getLongitude", "()D"); 
			global::android.location.Location._setLongitude4064 = @__env.GetMethodID(global::android.location.Location.staticClass, "setLongitude", "(D)V"); 
			global::android.location.Location._setExtras4065 = @__env.GetMethodID(global::android.location.Location.staticClass, "setExtras", "(Landroid/os/Bundle;)V"); 
			global::android.location.Location._setAccuracy4066 = @__env.GetMethodID(global::android.location.Location.staticClass, "setAccuracy", "(F)V"); 
			global::android.location.Location._getAccuracy4067 = @__env.GetMethodID(global::android.location.Location.staticClass, "getAccuracy", "()F"); 
			global::android.location.Location._distanceBetween4068 = @__env.GetStaticMethodID(global::android.location.Location.staticClass, "distanceBetween", "(DDDD[F)V"); 
			global::android.location.Location._distanceTo4069 = @__env.GetMethodID(global::android.location.Location.staticClass, "distanceTo", "(Landroid/location/Location;)F"); 
			global::android.location.Location._bearingTo4070 = @__env.GetMethodID(global::android.location.Location.staticClass, "bearingTo", "(Landroid/location/Location;)F"); 
			global::android.location.Location._setProvider4071 = @__env.GetMethodID(global::android.location.Location.staticClass, "setProvider", "(Ljava/lang/String;)V"); 
			global::android.location.Location._hasAltitude4072 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasAltitude", "()Z"); 
			global::android.location.Location._getAltitude4073 = @__env.GetMethodID(global::android.location.Location.staticClass, "getAltitude", "()D"); 
			global::android.location.Location._setAltitude4074 = @__env.GetMethodID(global::android.location.Location.staticClass, "setAltitude", "(D)V"); 
			global::android.location.Location._removeAltitude4075 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeAltitude", "()V"); 
			global::android.location.Location._hasSpeed4076 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasSpeed", "()Z"); 
			global::android.location.Location._getSpeed4077 = @__env.GetMethodID(global::android.location.Location.staticClass, "getSpeed", "()F"); 
			global::android.location.Location._setSpeed4078 = @__env.GetMethodID(global::android.location.Location.staticClass, "setSpeed", "(F)V"); 
			global::android.location.Location._removeSpeed4079 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeSpeed", "()V"); 
			global::android.location.Location._hasBearing4080 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasBearing", "()Z"); 
			global::android.location.Location._getBearing4081 = @__env.GetMethodID(global::android.location.Location.staticClass, "getBearing", "()F"); 
			global::android.location.Location._setBearing4082 = @__env.GetMethodID(global::android.location.Location.staticClass, "setBearing", "(F)V"); 
			global::android.location.Location._removeBearing4083 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeBearing", "()V"); 
			global::android.location.Location._hasAccuracy4084 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasAccuracy", "()Z"); 
			global::android.location.Location._removeAccuracy4085 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeAccuracy", "()V"); 
			global::android.location.Location._Location4086 = @__env.GetMethodID(global::android.location.Location.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.location.Location._Location4087 = @__env.GetMethodID(global::android.location.Location.staticClass, "<init>", "(Landroid/location/Location;)V"); 
		} 
	} 
} 
