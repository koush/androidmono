namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Location : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Location() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.Location), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString4274; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Location._toString4274)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Location.staticClass, global::android.location.Location._toString4274)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set4275; 
		public virtual void set(android.location.Location arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._set4275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._set4275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset4276; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._reset4276); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._reset4276); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTime4277; 
		public virtual void setTime(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._setTime4277, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setTime4277, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTime4278; 
		public virtual long getTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallLongMethod(this, global::android.location.Location._getTime4278); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getTime4278); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProvider4279; 
		public virtual global::java.lang.String getProvider() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Location._getProvider4279)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Location.staticClass, global::android.location.Location._getProvider4279)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convert4280; 
		public static double convert(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticDoubleMethod(android.location.Location.staticClass, global::android.location.Location._convert4280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convert4281; 
		public static global::java.lang.String convert(double arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.location.Location.staticClass, global::android.location.Location._convert4281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump4282; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._dump4282, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._dump4282, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4283; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._writeToParcel4283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._writeToParcel4283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4284; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallIntMethod(this, global::android.location.Location._describeContents4284); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Location.staticClass, global::android.location.Location._describeContents4284); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras4285; 
		public virtual global::android.os.Bundle getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Location._getExtras4285)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Location.staticClass, global::android.location.Location._getExtras4285)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLatitude4286; 
		public virtual double getLatitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallDoubleMethod(this, global::android.location.Location._getLatitude4286); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getLatitude4286); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLatitude4287; 
		public virtual void setLatitude(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._setLatitude4287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setLatitude4287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLongitude4288; 
		public virtual double getLongitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallDoubleMethod(this, global::android.location.Location._getLongitude4288); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getLongitude4288); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLongitude4289; 
		public virtual void setLongitude(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._setLongitude4289, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setLongitude4289, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtras4290; 
		public virtual void setExtras(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._setExtras4290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setExtras4290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAccuracy4291; 
		public virtual void setAccuracy(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._setAccuracy4291, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setAccuracy4291, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAccuracy4292; 
		public virtual float getAccuracy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallFloatMethod(this, global::android.location.Location._getAccuracy4292); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getAccuracy4292); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _distanceBetween4293; 
		public static void distanceBetween(double arg0, double arg1, double arg2, double arg3, float[] arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.location.Location.staticClass, global::android.location.Location._distanceBetween4293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _distanceTo4294; 
		public virtual float distanceTo(android.location.Location arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallFloatMethod(this, global::android.location.Location._distanceTo4294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.Location.staticClass, global::android.location.Location._distanceTo4294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bearingTo4295; 
		public virtual float bearingTo(android.location.Location arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallFloatMethod(this, global::android.location.Location._bearingTo4295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.Location.staticClass, global::android.location.Location._bearingTo4295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProvider4296; 
		public virtual void setProvider(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._setProvider4296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setProvider4296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAltitude4297; 
		public virtual bool hasAltitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallBooleanMethod(this, global::android.location.Location._hasAltitude4297); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Location.staticClass, global::android.location.Location._hasAltitude4297); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAltitude4298; 
		public virtual double getAltitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallDoubleMethod(this, global::android.location.Location._getAltitude4298); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getAltitude4298); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAltitude4299; 
		public virtual void setAltitude(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._setAltitude4299, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setAltitude4299, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAltitude4300; 
		public virtual void removeAltitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._removeAltitude4300); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._removeAltitude4300); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasSpeed4301; 
		public virtual bool hasSpeed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallBooleanMethod(this, global::android.location.Location._hasSpeed4301); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Location.staticClass, global::android.location.Location._hasSpeed4301); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpeed4302; 
		public virtual float getSpeed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallFloatMethod(this, global::android.location.Location._getSpeed4302); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getSpeed4302); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpeed4303; 
		public virtual void setSpeed(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._setSpeed4303, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setSpeed4303, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeSpeed4304; 
		public virtual void removeSpeed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._removeSpeed4304); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._removeSpeed4304); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasBearing4305; 
		public virtual bool hasBearing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallBooleanMethod(this, global::android.location.Location._hasBearing4305); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Location.staticClass, global::android.location.Location._hasBearing4305); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBearing4306; 
		public virtual float getBearing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallFloatMethod(this, global::android.location.Location._getBearing4306); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getBearing4306); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBearing4307; 
		public virtual void setBearing(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._setBearing4307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setBearing4307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeBearing4308; 
		public virtual void removeBearing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._removeBearing4308); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._removeBearing4308); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAccuracy4309; 
		public virtual bool hasAccuracy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				return @__env.CallBooleanMethod(this, global::android.location.Location._hasAccuracy4309); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Location.staticClass, global::android.location.Location._hasAccuracy4309); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAccuracy4310; 
		public virtual void removeAccuracy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Location)) 
				@__env.CallVoidMethod(this, global::android.location.Location._removeAccuracy4310); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._removeAccuracy4310); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Location4311; 
		public Location(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.location.Location.staticClass, global::android.location.Location._Location4311, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Location4312; 
		public Location(android.location.Location arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.location.Location.staticClass, global::android.location.Location._Location4312, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4313; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.Location.staticClass = @__class; 
			global::android.location.Location._toString4274 = @__env.GetMethodID(global::android.location.Location.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.location.Location._set4275 = @__env.GetMethodID(global::android.location.Location.staticClass, "set", "(Landroid/location/Location;)V"); 
			global::android.location.Location._reset4276 = @__env.GetMethodID(global::android.location.Location.staticClass, "reset", "()V"); 
			global::android.location.Location._setTime4277 = @__env.GetMethodID(global::android.location.Location.staticClass, "setTime", "(J)V"); 
			global::android.location.Location._getTime4278 = @__env.GetMethodID(global::android.location.Location.staticClass, "getTime", "()J"); 
			global::android.location.Location._getProvider4279 = @__env.GetMethodID(global::android.location.Location.staticClass, "getProvider", "()Ljava/lang/String;"); 
			global::android.location.Location._convert4280 = @__env.GetStaticMethodID(global::android.location.Location.staticClass, "convert", "(Ljava/lang/String;)D"); 
			global::android.location.Location._convert4281 = @__env.GetStaticMethodID(global::android.location.Location.staticClass, "convert", "(DI)Ljava/lang/String;"); 
			global::android.location.Location._dump4282 = @__env.GetMethodID(global::android.location.Location.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.location.Location._writeToParcel4283 = @__env.GetMethodID(global::android.location.Location.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.location.Location._describeContents4284 = @__env.GetMethodID(global::android.location.Location.staticClass, "describeContents", "()I"); 
			global::android.location.Location._getExtras4285 = @__env.GetMethodID(global::android.location.Location.staticClass, "getExtras", "()Landroid/os/Bundle;"); 
			global::android.location.Location._getLatitude4286 = @__env.GetMethodID(global::android.location.Location.staticClass, "getLatitude", "()D"); 
			global::android.location.Location._setLatitude4287 = @__env.GetMethodID(global::android.location.Location.staticClass, "setLatitude", "(D)V"); 
			global::android.location.Location._getLongitude4288 = @__env.GetMethodID(global::android.location.Location.staticClass, "getLongitude", "()D"); 
			global::android.location.Location._setLongitude4289 = @__env.GetMethodID(global::android.location.Location.staticClass, "setLongitude", "(D)V"); 
			global::android.location.Location._setExtras4290 = @__env.GetMethodID(global::android.location.Location.staticClass, "setExtras", "(Landroid/os/Bundle;)V"); 
			global::android.location.Location._setAccuracy4291 = @__env.GetMethodID(global::android.location.Location.staticClass, "setAccuracy", "(F)V"); 
			global::android.location.Location._getAccuracy4292 = @__env.GetMethodID(global::android.location.Location.staticClass, "getAccuracy", "()F"); 
			global::android.location.Location._distanceBetween4293 = @__env.GetStaticMethodID(global::android.location.Location.staticClass, "distanceBetween", "(DDDD[F)V"); 
			global::android.location.Location._distanceTo4294 = @__env.GetMethodID(global::android.location.Location.staticClass, "distanceTo", "(Landroid/location/Location;)F"); 
			global::android.location.Location._bearingTo4295 = @__env.GetMethodID(global::android.location.Location.staticClass, "bearingTo", "(Landroid/location/Location;)F"); 
			global::android.location.Location._setProvider4296 = @__env.GetMethodID(global::android.location.Location.staticClass, "setProvider", "(Ljava/lang/String;)V"); 
			global::android.location.Location._hasAltitude4297 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasAltitude", "()Z"); 
			global::android.location.Location._getAltitude4298 = @__env.GetMethodID(global::android.location.Location.staticClass, "getAltitude", "()D"); 
			global::android.location.Location._setAltitude4299 = @__env.GetMethodID(global::android.location.Location.staticClass, "setAltitude", "(D)V"); 
			global::android.location.Location._removeAltitude4300 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeAltitude", "()V"); 
			global::android.location.Location._hasSpeed4301 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasSpeed", "()Z"); 
			global::android.location.Location._getSpeed4302 = @__env.GetMethodID(global::android.location.Location.staticClass, "getSpeed", "()F"); 
			global::android.location.Location._setSpeed4303 = @__env.GetMethodID(global::android.location.Location.staticClass, "setSpeed", "(F)V"); 
			global::android.location.Location._removeSpeed4304 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeSpeed", "()V"); 
			global::android.location.Location._hasBearing4305 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasBearing", "()Z"); 
			global::android.location.Location._getBearing4306 = @__env.GetMethodID(global::android.location.Location.staticClass, "getBearing", "()F"); 
			global::android.location.Location._setBearing4307 = @__env.GetMethodID(global::android.location.Location.staticClass, "setBearing", "(F)V"); 
			global::android.location.Location._removeBearing4308 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeBearing", "()V"); 
			global::android.location.Location._hasAccuracy4309 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasAccuracy", "()Z"); 
			global::android.location.Location._removeAccuracy4310 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeAccuracy", "()V"); 
			global::android.location.Location._Location4311 = @__env.GetMethodID(global::android.location.Location.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.location.Location._Location4312 = @__env.GetMethodID(global::android.location.Location.staticClass, "<init>", "(Landroid/location/Location;)V"); 
		} 
	} 
} 
