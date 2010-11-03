namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLInput_))]
	public partial interface SQLInput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object readObject();
		int readInt();
		byte[] readBytes();
		long readLong();
		byte readByte();
		short readShort();
		float readFloat();
		bool readBoolean();
		double readDouble();
		global::java.lang.String readString();
		global::java.sql.Array readArray();
		bool wasNull();
		global::java.math.BigDecimal readBigDecimal();
		global::java.sql.Date readDate();
		global::java.sql.Time readTime();
		global::java.sql.Timestamp readTimestamp();
		global::java.io.Reader readCharacterStream();
		global::java.io.InputStream readAsciiStream();
		global::java.io.InputStream readBinaryStream();
		global::java.sql.Ref readRef();
		global::java.sql.Blob readBlob();
		global::java.sql.Clob readClob();
		global::java.net.URL readURL();
		global::java.lang.String readNString();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLInput))]
	internal sealed partial class SQLInput_ : java.lang.Object, SQLInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.sql.SQLInput.readObject()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readObject", "()Ljava/lang/Object;", ref global::java.sql.SQLInput_._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int java.sql.SQLInput.readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.SQLInput_.staticClass, "readInt", "()I", ref global::java.sql.SQLInput_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		byte[] java.sql.SQLInput.readBytes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.sql.SQLInput_.staticClass, "readBytes", "()[B", ref global::java.sql.SQLInput_._m2) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		long java.sql.SQLInput.readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.SQLInput_.staticClass, "readLong", "()J", ref global::java.sql.SQLInput_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		byte java.sql.SQLInput.readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.sql.SQLInput_.staticClass, "readByte", "()B", ref global::java.sql.SQLInput_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		short java.sql.SQLInput.readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.sql.SQLInput_.staticClass, "readShort", "()S", ref global::java.sql.SQLInput_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		float java.sql.SQLInput.readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.sql.SQLInput_.staticClass, "readFloat", "()F", ref global::java.sql.SQLInput_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool java.sql.SQLInput.readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.SQLInput_.staticClass, "readBoolean", "()Z", ref global::java.sql.SQLInput_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		double java.sql.SQLInput.readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.sql.SQLInput_.staticClass, "readDouble", "()D", ref global::java.sql.SQLInput_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.String java.sql.SQLInput.readString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.SQLInput_.staticClass, "readString", "()Ljava/lang/String;", ref global::java.sql.SQLInput_._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.sql.Array java.sql.SQLInput.readArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Array>(this, global::java.sql.SQLInput_.staticClass, "readArray", "()Ljava/sql/Array;", ref global::java.sql.SQLInput_._m10) as java.sql.Array;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.sql.SQLInput.wasNull()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.SQLInput_.staticClass, "wasNull", "()Z", ref global::java.sql.SQLInput_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.math.BigDecimal java.sql.SQLInput.readBigDecimal()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readBigDecimal", "()Ljava/math/BigDecimal;", ref global::java.sql.SQLInput_._m12) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::java.sql.Date java.sql.SQLInput.readDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readDate", "()Ljava/sql/Date;", ref global::java.sql.SQLInput_._m13) as java.sql.Date;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.sql.Time java.sql.SQLInput.readTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readTime", "()Ljava/sql/Time;", ref global::java.sql.SQLInput_._m14) as java.sql.Time;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.sql.Timestamp java.sql.SQLInput.readTimestamp()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readTimestamp", "()Ljava/sql/Timestamp;", ref global::java.sql.SQLInput_._m15) as java.sql.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.io.Reader java.sql.SQLInput.readCharacterStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readCharacterStream", "()Ljava/io/Reader;", ref global::java.sql.SQLInput_._m16) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::java.io.InputStream java.sql.SQLInput.readAsciiStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readAsciiStream", "()Ljava/io/InputStream;", ref global::java.sql.SQLInput_._m17) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.io.InputStream java.sql.SQLInput.readBinaryStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLInput_.staticClass, "readBinaryStream", "()Ljava/io/InputStream;", ref global::java.sql.SQLInput_._m18) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		global::java.sql.Ref java.sql.SQLInput.readRef()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Ref>(this, global::java.sql.SQLInput_.staticClass, "readRef", "()Ljava/sql/Ref;", ref global::java.sql.SQLInput_._m19) as java.sql.Ref;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::java.sql.Blob java.sql.SQLInput.readBlob()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Blob>(this, global::java.sql.SQLInput_.staticClass, "readBlob", "()Ljava/sql/Blob;", ref global::java.sql.SQLInput_._m20) as java.sql.Blob;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		global::java.sql.Clob java.sql.SQLInput.readClob()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Clob>(this, global::java.sql.SQLInput_.staticClass, "readClob", "()Ljava/sql/Clob;", ref global::java.sql.SQLInput_._m21) as java.sql.Clob;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		global::java.net.URL java.sql.SQLInput.readURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.sql.SQLInput_.staticClass, "readURL", "()Ljava/net/URL;", ref global::java.sql.SQLInput_._m22) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		global::java.lang.String java.sql.SQLInput.readNString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.SQLInput_.staticClass, "readNString", "()Ljava/lang/String;", ref global::java.sql.SQLInput_._m23) as java.lang.String;
		}
		static SQLInput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLInput"));
		}
	}
}
