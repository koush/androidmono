namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractCursor : java.lang.Object, CrossProcessCursor
	{ 
		internal static global::java.lang.Class staticClass; 
		static AbstractCursor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.AbstractCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected class SelfContentObserver : android.database.ContentObserver
		{ 
			internal new static global::java.lang.Class staticClass; 
			static SelfContentObserver() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.AbstractCursor.SelfContentObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.database.AbstractCursor.SelfContentObserver(@__env); 
				} 
			} 
			protected SelfContentObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _deliverSelfNotifications1989; 
			public override bool deliverSelfNotifications() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.AbstractCursor.SelfContentObserver)) 
					return @__env.CallBooleanMethod(this, _deliverSelfNotifications1989); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.SelfContentObserver.staticClass, _deliverSelfNotifications1989); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onChange1990; 
			public override void onChange(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.AbstractCursor.SelfContentObserver)) 
					@__env.CallVoidMethod(this, _onChange1990, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.SelfContentObserver.staticClass, _onChange1990, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SelfContentObserver1991; 
			public SelfContentObserver(android.database.AbstractCursor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.database.AbstractCursor.SelfContentObserver.staticClass, _SelfContentObserver1991, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.database.AbstractCursor.SelfContentObserver.staticClass = @__class; 
				global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications1989 = @__env.GetMethodID(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "deliverSelfNotifications", "()Z"); 
				global::android.database.AbstractCursor.SelfContentObserver._onChange1990 = @__env.GetMethodID(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "onChange", "(Z)V"); 
				global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver1991 = @__env.GetMethodID(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "<init>", "(Landroid/database/AbstractCursor;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort1992; 
		public abstract short getShort(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getInt1993; 
		public abstract int getInt(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getLong1994; 
		public abstract long getLong(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat1995; 
		public abstract float getFloat(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble1996; 
		public abstract double getDouble(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _close1997; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _close1997); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _close1997); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString1998; 
		public abstract java.lang.String getString(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _isFirst1999; 
		public virtual bool isFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isFirst1999); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isFirst1999); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed2000; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isClosed2000); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isClosed2000); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPosition2001; 
		public virtual int getPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallIntMethod(this, _getPosition2001); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.AbstractCursor.staticClass, _getPosition2001); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras2002; 
		public virtual android.os.Bundle getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getExtras2002)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _getExtras2002)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2003; 
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _registerContentObserver2003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _registerContentObserver2003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2004; 
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _unregisterContentObserver2004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _unregisterContentObserver2004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindow2005; 
		public virtual android.database.CursorWindow getWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallObjectMethodPtr(this, _getWindow2005)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _getWindow2005)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount2006; 
		public abstract int getCount(); 
		internal static global::net.sf.jni4net.jni.MethodId _move2007; 
		public virtual bool move(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _move2007, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _move2007, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPosition2008; 
		public virtual bool moveToPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _moveToPosition2008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _moveToPosition2008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToFirst2009; 
		public virtual bool moveToFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _moveToFirst2009); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _moveToFirst2009); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToLast2010; 
		public virtual bool moveToLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _moveToLast2010); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _moveToLast2010); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToNext2011; 
		public virtual bool moveToNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _moveToNext2011); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _moveToNext2011); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPrevious2012; 
		public virtual bool moveToPrevious() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _moveToPrevious2012); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _moveToPrevious2012); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLast2013; 
		public virtual bool isLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isLast2013); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isLast2013); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBeforeFirst2014; 
		public virtual bool isBeforeFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isBeforeFirst2014); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isBeforeFirst2014); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAfterLast2015; 
		public virtual bool isAfterLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isAfterLast2015); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isAfterLast2015); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2016; 
		public virtual int getColumnIndex(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallIntMethod(this, _getColumnIndex2016, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.AbstractCursor.staticClass, _getColumnIndex2016, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndexOrThrow2017; 
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallIntMethod(this, _getColumnIndexOrThrow2017, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.AbstractCursor.staticClass, _getColumnIndexOrThrow2017, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnName2018; 
		public virtual java.lang.String getColumnName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getColumnName2018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _getColumnName2018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2019; 
		public abstract java.lang.String[] getColumnNames(); 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnCount2020; 
		public virtual int getColumnCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallIntMethod(this, _getColumnCount2020); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.AbstractCursor.staticClass, _getColumnCount2020); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2021; 
		public virtual byte[] getBlob(int arg0) 
		{ 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getBlob2021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _getBlob2021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2022; 
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _copyStringToBuffer2022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _copyStringToBuffer2022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2023; 
		public abstract bool isNull(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2024; 
		public virtual void deactivate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _deactivate2024); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _deactivate2024); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requery2025; 
		public virtual bool requery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _requery2025); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _requery2025); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2026; 
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _registerDataSetObserver2026, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _registerDataSetObserver2026, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2027; 
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _unregisterDataSetObserver2027, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _unregisterDataSetObserver2027, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationUri2028; 
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _setNotificationUri2028, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _setNotificationUri2028, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWantsAllOnMoveCalls2029; 
		public virtual bool getWantsAllOnMoveCalls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _getWantsAllOnMoveCalls2029); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _getWantsAllOnMoveCalls2029); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _respond2030; 
		public virtual android.os.Bundle respond(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _respond2030, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _respond2030, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChange2031; 
		protected virtual void onChange(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _onChange2031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _onChange2031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMove2032; 
		public virtual bool onMove(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _onMove2032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _onMove2032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fillWindow2033; 
		public virtual void fillWindow(int arg0, android.database.CursorWindow arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _fillWindow2033, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _fillWindow2033, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFieldUpdated2034; 
		protected virtual bool isFieldUpdated(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isFieldUpdated2034, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isFieldUpdated2034, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUpdatedField2035; 
		protected virtual java.lang.Object getUpdatedField(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getUpdatedField2035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _getUpdatedField2035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkPosition2036; 
		protected virtual void checkPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _checkPosition2036); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _checkPosition2036); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractCursor2037; 
		public AbstractCursor()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.AbstractCursor.staticClass, _AbstractCursor2037, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.AbstractCursor.staticClass = @__class; 
			global::android.database.AbstractCursor._getShort1992 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getShort", "(I)S"); 
			global::android.database.AbstractCursor._getInt1993 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getInt", "(I)I"); 
			global::android.database.AbstractCursor._getLong1994 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getLong", "(I)J"); 
			global::android.database.AbstractCursor._getFloat1995 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getFloat", "(I)F"); 
			global::android.database.AbstractCursor._getDouble1996 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getDouble", "(I)D"); 
			global::android.database.AbstractCursor._close1997 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "close", "()V"); 
			global::android.database.AbstractCursor._getString1998 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.database.AbstractCursor._isFirst1999 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isFirst", "()Z"); 
			global::android.database.AbstractCursor._isClosed2000 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isClosed", "()Z"); 
			global::android.database.AbstractCursor._getPosition2001 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getPosition", "()I"); 
			global::android.database.AbstractCursor._getExtras2002 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getExtras", "()Landroid/os/Bundle;"); 
			global::android.database.AbstractCursor._registerContentObserver2003 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.AbstractCursor._unregisterContentObserver2004 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.AbstractCursor._getWindow2005 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;"); 
			global::android.database.AbstractCursor._getCount2006 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getCount", "()I"); 
			global::android.database.AbstractCursor._move2007 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "move", "(I)Z"); 
			global::android.database.AbstractCursor._moveToPosition2008 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToPosition", "(I)Z"); 
			global::android.database.AbstractCursor._moveToFirst2009 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToFirst", "()Z"); 
			global::android.database.AbstractCursor._moveToLast2010 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToLast", "()Z"); 
			global::android.database.AbstractCursor._moveToNext2011 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToNext", "()Z"); 
			global::android.database.AbstractCursor._moveToPrevious2012 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToPrevious", "()Z"); 
			global::android.database.AbstractCursor._isLast2013 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isLast", "()Z"); 
			global::android.database.AbstractCursor._isBeforeFirst2014 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isBeforeFirst", "()Z"); 
			global::android.database.AbstractCursor._isAfterLast2015 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isAfterLast", "()Z"); 
			global::android.database.AbstractCursor._getColumnIndex2016 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I"); 
			global::android.database.AbstractCursor._getColumnIndexOrThrow2017 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I"); 
			global::android.database.AbstractCursor._getColumnName2018 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnName", "(I)Ljava/lang/String;"); 
			global::android.database.AbstractCursor._getColumnNames2019 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;"); 
			global::android.database.AbstractCursor._getColumnCount2020 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnCount", "()I"); 
			global::android.database.AbstractCursor._getBlob2021 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getBlob", "(I)[B"); 
			global::android.database.AbstractCursor._copyStringToBuffer2022 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V"); 
			global::android.database.AbstractCursor._isNull2023 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isNull", "(I)Z"); 
			global::android.database.AbstractCursor._deactivate2024 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "deactivate", "()V"); 
			global::android.database.AbstractCursor._requery2025 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "requery", "()Z"); 
			global::android.database.AbstractCursor._registerDataSetObserver2026 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.AbstractCursor._unregisterDataSetObserver2027 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.AbstractCursor._setNotificationUri2028 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V"); 
			global::android.database.AbstractCursor._getWantsAllOnMoveCalls2029 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getWantsAllOnMoveCalls", "()Z"); 
			global::android.database.AbstractCursor._respond2030 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;"); 
			global::android.database.AbstractCursor._onChange2031 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "onChange", "(Z)V"); 
			global::android.database.AbstractCursor._onMove2032 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "onMove", "(II)Z"); 
			global::android.database.AbstractCursor._fillWindow2033 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V"); 
			global::android.database.AbstractCursor._isFieldUpdated2034 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isFieldUpdated", "(I)Z"); 
			global::android.database.AbstractCursor._getUpdatedField2035 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getUpdatedField", "(I)Ljava/lang/Object;"); 
			global::android.database.AbstractCursor._checkPosition2036 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "checkPosition", "()V"); 
			global::android.database.AbstractCursor._AbstractCursor2037 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "<init>", "()V"); 
		} 
	} 
} 
